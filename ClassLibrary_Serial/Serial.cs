using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;

namespace ClassLibrary_Serial
{

    /// <summary>
    /// 串口通信类
    /// </summary>
    public class Serial
    {
        SerialPort serialPort = new SerialPort();

        /// <summary>
        /// 构造函数
        /// </summary>
        public Serial()
        {
            //绑定数据接收事件
            serialPort.DataReceived += SerialPort_DataReceived;
           
        }

        /// <summary>
        /// 串口初始化设置
        /// </summary>
        /// <param name="port">端口号 </param>
        /// <param name="boud">波特率</param>
        /// <param name="databits">数据位长度</param>
        /// <param name="parity">校验位</param>
        /// <param name="stopBits">停止位长度</param>
        public  void Initserial(string port,int boud,int databits,Parity parity,StopBits stopBits)
        {
            serialPort.PortName = port;
            serialPort.BaudRate = boud;
            serialPort.DataBits = databits;
            serialPort.Parity = parity;
            serialPort.StopBits = stopBits;
        }

        public bool OpenSerial()
        {
            if (serialPort.IsOpen)
            {

            }
            else
            {
                serialPort.Open();
            }
            return true;
        }


        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
