using System;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Threading.Tasks;


namespace KACO_INVERTER_TEST
{
    public partial class Form1 : Form
    {
        CheckBox[] chk;
        string RxString, RxBuffer;
        string startHashtag = "#";
        string LastHeader = "0\r\n";
        int[] ArraySendorNot = new int[20];
        string[] KacoReadout = {
                                    "\n *0n 16 50kH3P 4 635.8 65.07 241.4 56.27 241.9 56.30 238.0 56.10 41376 40549 1.000 47.0 104017 2D5B",
                                    "\n *1n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *2n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *3n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *4n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *5n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *6n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *7n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *8n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *9n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *10n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *11n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *12n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *13n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *14n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *15n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *16n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *17n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *18n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    "\n *19n 23 160TR 12 1234.5 12.34 12345 1234.5 12.34 12345 1234.5 1234.5 12.34 12.34 1234.5 12.34 12345 12345 0.999c 123.4 123456",
                                    

                                };

        string[] RequestFromMcu = {
                                    "#10\r",
                                    "#20\r",
                                    "#30\r",
                                    "#40\r",
                                    "#50\r",
                                    "#60\r",
                                    "#70\r",
                                    "#80\r",
                                    "#90\r",
                                    "#100\r",
                                    "#110\r",
                                    "#120\r",
                                    "#130\r",
                                    "#140\r",
                                    "#150\r",
                                    "#160\r",
                                    "#170\r",
                                    "#180\r",
                                    "#190\r",
                                    "#200\r",
                                                };


        string[] ports = SerialPort.GetPortNames();

        public Form1()
        {
            InitializeComponent();
            chk = new CheckBox[20] {            chk1  ,chk2  ,chk3  , chk4  , chk5  , chk6  , chk7  , chk8 ,chk9,
                                                chk10 ,chk11 ,chk12 , chk13 , chk14 , chk15 , chk16 , chk17,
                                                chk18 ,chk19 ,chk20                                         };

            foreach (var checkbox in chk)
            {
                checkbox.CheckedChanged += new EventHandler(CheckToCheckBox);

            }

            serialPort1.Close();
        }
        public static void WriteDebugLog(String Message)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                sw.WriteLine(DateTime.Now.ToString() + ": " + Message);
                sw.Flush();
                sw.Close();
            }
            catch
            {

            }
        }


        private void ComPort_Enter(object sender, EventArgs e)
        {

        } 
        

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            foreach (string port in ports)
            {
                comboBox1.Items.Add(port);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.StopBits = StopBits.One;
            serialPort1.Parity = Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.WriteTimeout = 500;
            serialPort1.ReadTimeout = 500;
            serialPort1.Open();
            if (serialPort1.IsOpen)
            {
                label2.ForeColor = System.Drawing.Color.Green;
                label2.Text = "OK";      
            }
            else
            {
                label2.ForeColor = System.Drawing.Color.Red;
                label2.Text = "ERR";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            RxBuffer = "";
            RxString = serialPort1.ReadExisting();
            RxBuffer = RxBuffer + RxString;
            this.Invoke(new EventHandler(DisplayReceivedData));

        }

        public void CheckToCheckBox(object sender , EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                if (chk[i].Checked && chk[i].Enabled)
                {
                   
                    ArraySendorNot[i] = 1;

                }
                if (!chk[i].Checked && chk[i].Enabled)
                {
                    ArraySendorNot[i] = 0;

                }
            }
        }


        private void DisplayReceivedData(object sender , EventArgs e )
        {
            WriteDebugLog(RxBuffer);
            for (int i = 0; i < 20; i++)
            {
                if (string.Compare(RxBuffer, RequestFromMcu[i]) == 0 && checkBox3.Checked == true)
                {
                    if (ArraySendorNot[i] == 1)
                    {
                        serialPort1.WriteLine(KacoReadout[i]);
                        break;
                    }

                }
            }
            richTextBox1.AppendText("\n");

            foreach (char c in RxString)
                if (c < ' ')
                {
                    richTextBox1.SelectionStart = richTextBox1.TextLength;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.SelectionColor = System.Drawing.Color.Red;
                    richTextBox1.AppendText("<" + ((int)c).ToString() + ">");
                    richTextBox1.SelectionColor = richTextBox1.ForeColor;
                    if (c == '\x0a') richTextBox1.AppendText(Convert.ToString(c));

                }
                else
                    richTextBox1.AppendText(Convert.ToString(c));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        async Task putTaskDelay()
        {
            await Task.Delay(750);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == false && checkBox2.Checked == false )
            {
                string Send = String.Format ("{0}{1}{2}", startHashtag, textBox1.Text, LastHeader);

                serialPort1.Write (Send);
                richTextBox2.Text = Send.ToString();
            }
            if(checkBox1.Checked == true && checkBox2.Checked == false)
            {
                int OffsetValue = int.Parse(textBox2.Text);
                string Send;
                int SendId;
                for (int i = 0; i < OffsetValue + 1; i++)
                {
                     SendId = int.Parse (textBox1.Text) + i;
                     Send = String.Format ("{0}{1}{2}", startHashtag, SendId , LastHeader);
                     serialPort1.Write (Send);
                     richTextBox2.AppendText (Send.ToString());
                     await putTaskDelay();

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                label2.ForeColor = System.Drawing.Color.Black;
                label2.Text = "CLOSE";
            }
        }
    }
}
