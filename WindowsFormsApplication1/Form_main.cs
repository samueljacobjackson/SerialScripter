using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_main : Form
    {
        public BackgroundWorker bw_receive = new BackgroundWorker();
        public BackgroundWorker bw_send = new BackgroundWorker();
        public SerialPort serialConnection = new SerialPort();
        private delegate void SetTextDeleg(string data);
        private int tabCount = 1;
        
        public Form_main()
        {
            InitializeComponent();
        }

        private void TabControl_scripts_selected(object sender, TabControlEventArgs e)
        {
            string rtBoxName = tabControl_scripts.SelectedTab.Name + "_rtBox";
            if (!(this.Controls.Find(rtBoxName, true).FirstOrDefault() is RichTextBox))
                MakeRichTextBox();
        }

        private void MakeRichTextBox()
        {
            RichTextBox rtb = new RichTextBox();
            Size rtbSize = new Size(553, 323);
            Padding rtbPadding = new Padding(3);
            Point rtbPoint = new Point(6, 6);
            tabControl_scripts.SelectedTab.BackColor = Color.White;
            rtb.Name = tabControl_scripts.SelectedTab.Name + "_rtBox";
            rtb.BorderStyle = BorderStyle.None;
            tabControl_scripts.SelectedTab.Controls.Add(rtb);
            rtb.Dock = DockStyle.Fill;
            rtb.Size = rtbSize;
            rtb.Margin = rtbPadding;
            rtb.Location = rtbPoint;
            rtb.ContextMenuStrip = cMenu_script;
        }

        private void TabControl_scripts_drawItem(object sender, DrawItemEventArgs e)
        {
            RectangleF tabTextArea = RectangleF.Empty;
            tabTextArea.Width = e.Bounds.Width;
            tabTextArea.Height = e.Bounds.Height;
            tabTextArea.X = e.Bounds.X;
            tabTextArea.Y = e.Bounds.Y + 6;

            using (Bitmap bmp = new Bitmap(SerialScripter.Properties.Resources.TabClose))
            {
                e.Graphics.DrawImage(bmp, tabTextArea.X + tabTextArea.Width - 15, 8, 10, 10);
            }
            string str = tabControl_scripts.TabPages[e.Index].Text;
            StringFormat stringformat = new StringFormat
            {
                Alignment = StringAlignment.Center
            };
            using (SolidBrush brush = new SolidBrush(tabControl_scripts.TabPages[e.Index].ForeColor))
            {
                e.Graphics.DrawString(str, e.Font, brush, tabTextArea, stringformat);
            }
        }

        private void TabControl_scripts_mouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < this.tabControl_scripts.TabPages.Count; i++)
            {
                Rectangle r = tabControl_scripts.GetTabRect(i);
                //Getting the position of the "x" mark.
                Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 5, 10, 10);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Would you like to Close this Tab?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (tabControl_scripts.TabCount == 1)
                        {
                            tabCount += 1;
                            tabControl_scripts.TabPages.Add("tabPage_" + tabCount, "Script " + tabCount);
                            tabControl_scripts.SelectedIndex = tabControl_scripts.TabCount - 1;
                            this.tabControl_scripts.TabPages.RemoveAt(i);
                        }
                        else
                        {
                            this.tabControl_scripts.TabPages.RemoveAt(i);
                        }
                    }
                }
            }
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            PopulatePortNameComboBox();
            tabControl_scripts.TabPages[0].Name = "tabPage_1";
            tabPage1_rTxtBox.Name = "tabPage_1_rtBox";
            ss_status.Text = " ";
            serialConnection.DataReceived += DataReceivedHandler;
            serialConnection.PinChanged += PinChangedHandler;
        }
        
        public void PopulatePortNameComboBox()
        {
            string[] portList = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string s in portList)
            {
                cBox_portName.Items.Add(s);
            }
            cBox_portName.SelectedItem = portList[0];
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if(ss_RD.BackColor != Color.LawnGreen)
                        ss_RD.BackColor = Color.LawnGreen;
                });
                    
                SerialPort sp = (SerialPort)sender;
                string indata;

                int bytes = serialConnection.BytesToRead;
                switch (tBtn_receiveAsHex.Checked)
                {
                    case false:
                        char[] charBuffer = new char[bytes];
                        serialConnection.Read(charBuffer, 0, bytes);
                        indata = CharToAscii(charBuffer);
                        break;
                    case true:
                        byte[] byteBuffer = new byte[bytes];
                        serialConnection.Read(byteBuffer, 0, bytes);
                        indata = ByteToHex(byteBuffer);
                        break;
                    default:
                        indata = sp.ReadExisting();
                        break;
                }

                this.BeginInvoke(new SetTextDeleg(DisplayToUI), new object[] { indata });

                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_RD.BackColor != Color.IndianRed)
                        ss_RD.BackColor = Color.IndianRed;
                });
            }
            catch (Exception ex)
            {
                ss_status.Text = ex.Message;
            }
        }

        private void PinChangedHandler(object sender, SerialPinChangedEventArgs e)
        {
            if (serialConnection.CDHolding)
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_CD.BackColor != Color.LawnGreen)
                        ss_CD.BackColor = Color.LawnGreen;
                });
            }
            else
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_CD.BackColor != Color.IndianRed)
                        ss_CD.BackColor = Color.IndianRed;
                });
            }
            if (serialConnection.CtsHolding)
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_CTS.BackColor != Color.LawnGreen)
                        ss_CTS.BackColor = Color.LawnGreen;
                });
            }
            else
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_CTS.BackColor != Color.IndianRed)
                        ss_CTS.BackColor = Color.IndianRed;
                });
            }
            if (serialConnection.DsrHolding)
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_DSR.BackColor != Color.LawnGreen)
                        ss_DSR.BackColor = Color.LawnGreen;
                });
            }
            else
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_DSR.BackColor != Color.IndianRed)
                        ss_DSR.BackColor = Color.IndianRed;
                });
            }
            if (serialConnection.DtrEnable)
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_DTR.BackColor != Color.LawnGreen)
                        ss_DTR.BackColor = Color.LawnGreen;
                });
            }
            else
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_DTR.BackColor != Color.IndianRed)
                        ss_DTR.BackColor = Color.IndianRed;
                });
            }
            if (serialConnection.RtsEnable)
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_RTS.BackColor != Color.LawnGreen)
                        ss_RTS.BackColor = Color.LawnGreen;
                });
            }
            else
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_RTS.BackColor != Color.IndianRed)
                        ss_RTS.BackColor = Color.IndianRed;
                });
            }
        }

        private string ByteToHex(byte[] comByte)
        {
            StringBuilder sb = new StringBuilder(comByte.Length * 3);
            foreach (byte data in comByte)
            {
                sb.Append(Convert.ToString(data, 16).PadLeft(2, Convert.ToChar("0")).PadRight(3, Convert.ToChar(" ")));
            }
            return sb.ToString().ToUpper();
        }

        private string CharToAscii(char[] comChar)
        {
            StringBuilder sb = new StringBuilder(comChar.Length);
            foreach(char data in comChar)
            {
                sb.Append(Convert.ToString(data));
            }
            return sb.ToString();
        }

        private void DisplayToUI(string displayData)
        {
            rTxt_console.Text += displayData;
        }

        private void RTxt_console_keyDown(object sender, KeyEventArgs e)
        {
            _ = rTxt_console.TextLength;

            if (e.Control)
            {
                if (e.KeyCode == Keys.V)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (serialConnection.IsOpen)
                    {
                        serialConnection.Write("\r\n");
                    }
                    if(!tBtn_echo.Checked)
                        e.Handled = true;
                }
            }
        }

        private void RTxt_console_keyClick(object sender, KeyPressEventArgs e)
        {
            if (serialConnection.IsOpen)
            {
                ss_TD.BackColor = Color.LawnGreen;
                serialConnection.Write(Convert.ToString(e.KeyChar));
                ss_TD.BackColor = Color.IndianRed;
            }

            if (tBtn_echo.Checked == false)
                e.Handled = true;
        }

        private void TBtn_new_Click(object sender, EventArgs e)
        {
            tabCount += 1;
            tabControl_scripts.TabPages.Add("tabPage_" + tabCount, "Script " + tabCount);
            tabControl_scripts.SelectedIndex = tabControl_scripts.TabCount - 1;
        }

        private void TBtn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog od = new OpenFileDialog
            {
                Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*",
                FilterIndex = 2,

                Multiselect = true
            };

            od.ShowDialog();

            if (od.FileNames.Length > 0)
            {
                foreach (string file in od.FileNames)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    if (fileName.Length > 8)
                        fileName = fileName.Substring(0, 8)+"...";
                    tabCount += 1;
                    tabControl_scripts.TabPages.Add("tabPage_" + tabCount, fileName);
                    tabControl_scripts.SelectedIndex = tabControl_scripts.TabCount - 1;
                    MakeRichTextBox();
                    string rtBoxName = tabControl_scripts.SelectedTab.Name + "_rtBox";
                    RichTextBox rtBoxObj = this.Controls.Find(rtBoxName, true).FirstOrDefault() as RichTextBox;
                    using (StreamReader sr = new StreamReader(file))
                    {
                        string line = sr.ReadToEnd();
                        rtBoxObj.Text = line;
                    }
                }
            }
        }

        private void TBtn_save_con_Click(object sender, EventArgs e)
        {
            string text = rTxt_console.Text;

            SaveFileDialog sd = new SaveFileDialog
            {
                Filter = "Text File|*.txt|All Files|*.*",
                FilterIndex = 2
            };
            sd.ShowDialog();

            if (sd.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(sd.FileName))
                {
                    sw.WriteLine(text);
                }
            }
        }

        public void Bw_saveConsole(object sender, DoWorkEventArgs e)
        {
            
        }

        private void TBtn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sd = new SaveFileDialog
            {
                Filter = "Text File|*.txt|All Files|*.*",
                FilterIndex = 2
            };
            sd.ShowDialog();

            string rtBoxName = tabControl_scripts.SelectedTab.Name + "_rtBox";
            RichTextBox rtBoxObj = this.Controls.Find(rtBoxName, true).FirstOrDefault() as RichTextBox;

            if (sd.FileName != "")
            {
                using (StreamWriter sw = new StreamWriter(sd.FileName))
                {
                    sw.WriteLine(rtBoxObj.Text);
                }
            }
        }

        private void TBtn_receiveAsAscii_Click(object sender, EventArgs e)
        {
            if (tBtn_receiveAsAscii.Checked == false)
            {
                tBtn_receiveAsAscii.Checked = true;
                tBtn_receiveAsHex.Checked = false;
            }
        }

        private void TBtn_receiveAsHex_Click(object sender, EventArgs e)
        {
            if (tBtn_receiveAsHex.Checked == false)
            {
                tBtn_receiveAsHex.Checked = true;
                tBtn_receiveAsAscii.Checked = false;
            }
        }

        private void TBtn_sendAsAscii_Click(object sender, EventArgs e)
        {
            if (tBtn_sendAsAscii.Checked == false)
            {
                tBtn_sendAsAscii.Checked = true;
                tBtn_sendAsHex.Checked = false;
            }
        }

        private void TBtn_sendAsHex_Click(object sender, EventArgs e)
        {
            if (tBtn_sendAsHex.Checked == false)
            {
                tBtn_sendAsHex.Checked = true;
                tBtn_sendAsAscii.Checked = false;
            }
        }

        private void Bw_closeSerialConnection(object sender, DoWorkEventArgs e)
        {
           while (serialConnection.IsOpen)
                serialConnection.Close();
        }

        private void Bw_closeSerialCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tBtn_connect.Checked = false;
            ss_CD.BackColor = Color.Transparent;
            ss_CTS.BackColor = Color.Transparent;
            ss_DSR.BackColor = Color.Transparent;
            ss_DTR.BackColor = Color.Transparent;
            ss_RD.BackColor = Color.Transparent;
            ss_RTS.BackColor = Color.Transparent;
            ss_TD.BackColor = Color.Transparent;
        }

        private void TBtn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                ss_status.Text = " ";

                if (serialConnection.IsOpen)
                {
                    bw_receive = new BackgroundWorker();
                    bw_receive.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Bw_closeSerialCompleted);
                    bw_receive.DoWork += Bw_closeSerialConnection;
                    bw_receive.RunWorkerAsync(serialConnection);
                }
                else
                {
                    serialConnection.PortName = cBox_portName.Text;
                    serialConnection.BaudRate = int.Parse(cBox_speedBaud.Text);
                    serialConnection.DataBits = int.Parse(cBox_dataBits.Text);
                    switch (cBox_stopBits.Text)
                    {
                        case "One":
                            serialConnection.StopBits = StopBits.One;
                            break;
                        case "Two":
                            serialConnection.StopBits = StopBits.Two;
                            break;
                        case "1 1/2":
                            serialConnection.StopBits = StopBits.OnePointFive;
                            break;
                        case "None":
                            serialConnection.StopBits = StopBits.None;
                            break;
                        default:
                            serialConnection.StopBits = StopBits.None;
                            break;
                    }
                    switch (cBox_parity.Text)
                    {
                        case "None":
                            serialConnection.Parity = Parity.None;
                            break;
                        case "Even":
                            serialConnection.Parity = Parity.Even;
                            break;
                        case "Mark":
                            serialConnection.Parity = Parity.Mark;
                            break;
                        case "Odd":
                            serialConnection.Parity = Parity.Odd;
                            break;
                        case "Space":
                            serialConnection.Parity = Parity.Space;
                            break;
                        default:
                            serialConnection.Parity = Parity.None;
                            break;
                    }
                    switch (cBox_flowControl.Text)
                    {
                        case "None":
                            serialConnection.Handshake = Handshake.None;
                            serialConnection.DtrEnable = true;
                            serialConnection.RtsEnable = true;
                            break;
                        case "Request To Send":
                            serialConnection.Handshake = Handshake.RequestToSend;
                            break;
                        case "Request XOn/XOff":
                            serialConnection.Handshake = Handshake.RequestToSendXOnXOff;
                            break;
                        case "XOn/XOff":
                            serialConnection.Handshake = Handshake.XOnXOff;
                            break;
                        default:
                            serialConnection.Handshake = Handshake.None;
                            break;
                    }
                    serialConnection.ReadTimeout = int.Parse(tBox_readTimeout.Text);
                    serialConnection.WriteTimeout = int.Parse(tBox_writeTimeout.Text);

                    if (!(serialConnection.IsOpen))
                        serialConnection.Open();

                    if (serialConnection.IsOpen)
                    {
                        tBtn_connect.Checked = true;
                        if (serialConnection.IsOpen)
                        {
                            ss_CD.BackColor = Color.IndianRed;
                            ss_CTS.BackColor = Color.IndianRed;
                            ss_DSR.BackColor = Color.IndianRed;
                            ss_DTR.BackColor = Color.IndianRed;
                            ss_RD.BackColor = Color.IndianRed;
                            ss_RTS.BackColor = Color.IndianRed;
                            ss_TD.BackColor = Color.IndianRed;
                            if (serialConnection.CDHolding)
                                ss_CD.BackColor = Color.LawnGreen;
                            if(serialConnection.CtsHolding)
                                ss_CTS.BackColor = Color.LawnGreen;
                            if(serialConnection.DsrHolding)
                                ss_DSR.BackColor = Color.LawnGreen;
                            if(serialConnection.DtrEnable)
                                ss_DTR.BackColor = Color.LawnGreen;
                            if(serialConnection.RtsEnable)
                                ss_RTS.BackColor = Color.LawnGreen;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (serialConnection.IsOpen) serialConnection.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TBtn_send_Click(object sender, EventArgs e)
        {
            if (tBtn_send.Checked)
            {
                tBtn_send.Checked = false;
                bw_send.WorkerSupportsCancellation = true;
                bw_send.CancelAsync();
            }
            else
            {
                tBtn_send.Checked = true;
                if (!(serialConnection.IsOpen))
                    return;
                
                string rtBoxName = tabControl_scripts.SelectedTab.Name + "_rtBox";
                RichTextBox rtBoxObj = this.Controls.Find(rtBoxName, true).FirstOrDefault() as RichTextBox;

                switch (tBtn_sendAsHex.Checked)
                {
                    case false:
                        bw_send = new BackgroundWorker
                        {
                            WorkerSupportsCancellation = true
                        };
                        bw_send.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Bw_runWorkerCompleted);
                        bw_send.DoWork += Bw_sendAscii;
                        bw_send.RunWorkerAsync(rtBoxObj.Text);
                        break;
                    case true:
                        bw_send = new BackgroundWorker
                        {
                            WorkerSupportsCancellation = true
                        };
                        bw_send.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Bw_runWorkerCompleted);
                        bw_send.DoWork += Bw_sendHex;
                        bw_send.RunWorkerAsync(rtBoxObj.Text);
                        break;
                    default:
                        serialConnection.Write(rtBoxObj.Text);
                        break;
                }
            }
        }

        private void RTxt_console_TextChanged(object sender, EventArgs e)
        {
            if (rTxt_console.TextLength >= 2047483640)
                rTxt_console.Text = rTxt_console.Text.Substring(rTxt_console.TextLength - 2047483639, rTxt_console.TextLength);
        }

        private void Bw_sendHex(object sender, DoWorkEventArgs e)
        {
            string hex = (string)e.Argument;
            hex = hex.Replace(" ", "");

            byte[] hexByte = new byte[1];
            for (int i = 0; i < hex.Length; i+=2)
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_TD.BackColor != Color.LawnGreen)
                        ss_TD.BackColor = Color.LawnGreen;
                });

                hexByte[0] = Convert.ToByte(Int32.Parse(hex.Substring(i,2),System.Globalization.NumberStyles.HexNumber));
                serialConnection.Write(hexByte, 0, 1);
                if (bw_receive.CancellationPending)
                    break;

                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_TD.BackColor != Color.IndianRed)
                        ss_TD.BackColor = Color.IndianRed;
                });
            }
        }

        private void Bw_sendAscii(object sender, DoWorkEventArgs e)
        {
            string ascii = (string)e.Argument;
            char[] asciiChar = new char[1];
            for (int i = 0; i < ascii.Length; i++)
            {
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_TD.BackColor != Color.LawnGreen)
                        ss_TD.BackColor = Color.LawnGreen;
                });

                asciiChar[0] = Convert.ToChar(ascii.Substring(i,1));

                if (serialConnection.IsOpen)
                {
                    serialConnection.Write(asciiChar, 0, 1);
                }
                else
                {
                    break;
                }
                
                if (bw_receive.CancellationPending)
                    break;
                
                statusStrip2.Invoke((MethodInvoker)delegate
                {
                    if (ss_TD.BackColor != Color.IndianRed)
                        ss_TD.BackColor = Color.IndianRed;
                });
            }
        }

        private void Bw_runWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            statusStrip2.Invoke((MethodInvoker)delegate
            {
                if (ss_TD.BackColor != Color.IndianRed)
                    ss_TD.BackColor = Color.IndianRed;
            });
            if(serialConnection.IsOpen)
                serialConnection.DiscardOutBuffer();

            tBtn_send.Checked = false;
        }

        private void TBtn_clearConsole_Click(object sender, EventArgs e)
        {
            rTxt_console.Clear();
        }

        private void CMenu_scriptCut_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
            {
                Clipboard.SetDataObject(((TextBox)this.ActiveControl).SelectedText, true);
                ((TextBox)this.ActiveControl).SelectedText = "";
            }
            if (ActiveControl is RichTextBox)
            {
                Clipboard.SetDataObject(((RichTextBox)this.ActiveControl).SelectedText, true);
                ((RichTextBox)this.ActiveControl).SelectedText = "";
            }
        }
        
        private void CMenu_scriptCopy_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
                Clipboard.SetDataObject(((TextBox)this.ActiveControl).SelectedText, true);

            if (ActiveControl is RichTextBox)
                Clipboard.SetDataObject(((RichTextBox)this.ActiveControl).SelectedText, true);
        }

        private void CMenu_scriptPaste_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
                ((TextBox)this.ActiveControl).SelectedText = Clipboard.GetText();

            if (ActiveControl is RichTextBox)
                ((RichTextBox)this.ActiveControl).SelectedText = Clipboard.GetText();
        }

        private void CMenu_scriptDelete_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
                ((TextBox)this.ActiveControl).SelectedText = "";

            if (ActiveControl is RichTextBox)
                ((RichTextBox)this.ActiveControl).SelectedText = "";
        }

        private void CMenu_scriptSelectAll_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
                ((TextBox)this.ActiveControl).SelectAll();

            if (ActiveControl is RichTextBox)
                ((RichTextBox)this.ActiveControl).SelectAll();
        }

        private void CMenu_consoleCut_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
            {
                Clipboard.SetDataObject(((TextBox)this.ActiveControl).SelectedText, true);
                ((TextBox)this.ActiveControl).SelectedText = "";
            }
            if (ActiveControl is RichTextBox)
            {
                Clipboard.SetDataObject(((RichTextBox)this.ActiveControl).SelectedText, true);
                ((RichTextBox)this.ActiveControl).SelectedText = "";
            }
        }

        private void CMenu_consoleCopy_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
                Clipboard.SetDataObject(((TextBox)this.ActiveControl).SelectedText, true);

            if (ActiveControl is RichTextBox)
                Clipboard.SetDataObject(((RichTextBox)this.ActiveControl).SelectedText, true);
        }

        private void CMenu_consolePaste_Click(object sender, EventArgs e)
        {
           if (bw_send.IsBusy != true)
           {
                if (!(serialConnection.IsOpen))
                    return;

                string text = Clipboard.GetText();

                bw_send = new BackgroundWorker();
                bw_send.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Bw_runWorkerCompleted);
                bw_send.WorkerSupportsCancellation = true;
                bw_send.DoWork += Bw_sendAscii;
                bw_send.RunWorkerAsync(text);
            }

            if (tBtn_echo.Checked)
                rTxt_console.SelectedText = Clipboard.GetText();
            
        }

        private void CMenu_consoleSelectAll_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
                ((TextBox)this.ActiveControl).SelectAll();

            if (ActiveControl is RichTextBox)
                ((RichTextBox)this.ActiveControl).SelectAll();
        }

        private void CMenu_consoleClear_Click(object sender, EventArgs e)
        {
            rTxt_console.Clear();
        }

        private void TBtn_cut_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
            {
                Clipboard.SetDataObject(((TextBox)this.ActiveControl).SelectedText, true);
                ((TextBox)this.ActiveControl).SelectedText = "";
            }
            if (ActiveControl is RichTextBox)
            {
                Clipboard.SetDataObject(((RichTextBox)this.ActiveControl).SelectedText, true);
                ((RichTextBox)this.ActiveControl).SelectedText = "";
            }
        }

        private void TBtn_copy_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBox)
                Clipboard.SetDataObject(((TextBox)this.ActiveControl).SelectedText, true);

            if (ActiveControl is RichTextBox)
                Clipboard.SetDataObject(((RichTextBox)this.ActiveControl).SelectedText, true);
        }

        private void TBtn_paste_Click(object sender, EventArgs e)
        {
            if (this.ActiveControl == rTxt_console)
            {
                if (bw_send.IsBusy != true)
                {
                    if (!(serialConnection.IsOpen))
                        return;

                    string text = Clipboard.GetText();

                    bw_send = new BackgroundWorker();
                    bw_send.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Bw_runWorkerCompleted);
                    bw_send.WorkerSupportsCancellation = true;
                    bw_send.DoWork += Bw_sendAscii;
                    bw_send.RunWorkerAsync(text);
                }

                if (tBtn_echo.Checked)
                    rTxt_console.SelectedText = Clipboard.GetText();
            }
            else
            {
                if (ActiveControl is TextBox)
                    ((TextBox)this.ActiveControl).SelectedText = Clipboard.GetText();

                if (ActiveControl is RichTextBox)
                    ((RichTextBox)this.ActiveControl).SelectedText = Clipboard.GetText();
            }
        }
    }
}
