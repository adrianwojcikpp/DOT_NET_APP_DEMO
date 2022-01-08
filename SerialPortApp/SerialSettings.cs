/**
 *   @file SerialSettings.cs
 *   @author AW    @adrian.wojcik@put.poznan.pl
 *   @date 02-Nov-17
 *   @brief Serial port settings class. 
 *          Based on project by Amund Gjersøe 
 *   @ref   www.codeproject.com/Articles/75770/Basic-serial-port-listening-application
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.ComponentModel;

namespace SerialPortApp.Serial
{
    /**
     * @brief Class containing properties related to a serial port 
     */
    public class SerialSettings : INotifyPropertyChanged
    {
        #region Fields

        string _portName = "";              /**< Serial port name. */
        int _baudRate = 115200;             /**< Serial port badu rate. */
        Parity _parity = Parity.None;       /**< Serial port parity. */
        int _dataBits = 8;                  /**< Serial port data bits number. */
        StopBits _stopBits = StopBits.One;  /**< Serial port stop bits number. */

        string[] _portNameCollection;                                   /**< Serial port name collection. */
        readonly int[] _dataBitsCollection = new int[] { 5, 6, 7, 8 };           /**< Serial port data bits collection. */
        readonly BindingList<int> _baudRateCollection = new BindingList<int>();  /**< Serial port setable baud rate collection */

        public delegate void BaudRateCollectionUpdateHandlerType();
        public BaudRateCollectionUpdateHandlerType BaudRateCollectionUpdateHandler;
        public event PropertyChangedEventHandler PropertyChanged;       /**< Property changed handling evnet. */

        #endregion

        #region Properties

        /**
         * @brief The port to use (for example, COM1).
         */
        public string PortName
        {
            get { return _portName; }
            set
            {
                if (!_portName.Equals(value))
                {
                    _portName = value;
                    SendPropertyChangedEvent("PortName");
                }
            }
        }

        /**
         * @brief The baud rate.
         */
        public int BaudRate
        {
            get { return _baudRate; }
            set 
            {
                if (_baudRate != value)
                {
                    _baudRate = value;
                    SendPropertyChangedEvent("BaudRate");
                }
            }
        }

        /**
         * @brief One of the Parity values.
         */
        public Parity Parity
        {
            get { return _parity; }
            set 
            {
                if (_parity != value)
                {
                    _parity = value;
                    SendPropertyChangedEvent("Parity");
                }
            }
        }

        /**
         * @brief  The data bits value.
         */
        public int DataBits
        {
            get { return _dataBits; }
            set
            {
                if (_dataBits != value)
                {
                    _dataBits = value;
                    SendPropertyChangedEvent("DataBits");
                }
            }
        }

        /**
         * @brief One of the StopBits values.
         */
        public StopBits StopBits
        {
            get { return _stopBits; }
            set
            {
                if (_stopBits != value)
                {
                    _stopBits = value;
                    SendPropertyChangedEvent("StopBits");
                }
            }
        }

        /**
         * @brief Available ports on the computer
         */
        public string[] PortNameCollection
        {
            get { return _portNameCollection; }
            set { _portNameCollection = value; }
        }

        /**
         * @brief Available baud rates for current serial port
         */
        public BindingList<int> BaudRateCollection
        {
            get { return _baudRateCollection; }
        }

        /**
         * @brief Available databits setting
         */
        public int[] DataBitsCollection
        {
            get { return _dataBitsCollection; } 
        }

        #endregion

        #region Methods

        /**
         * @brief Updates the range of possible baud rates for device
         * @param[in] possibleBaudRates : dwSettableBaud parameter from the COMMPROP Structure
         */
        public void UpdateBaudRateCollection(int possibleBaudRates)
        {
            const int BAUD_075 = 0x00000001;
            const int BAUD_110 = 0x00000002;
            const int BAUD_150 = 0x00000008;
            const int BAUD_300 = 0x00000010;
            const int BAUD_600 = 0x00000020;
            const int BAUD_1200 = 0x00000040;
            const int BAUD_1800 = 0x00000080;
            const int BAUD_2400 = 0x00000100;
            const int BAUD_4800 = 0x00000200;
            const int BAUD_7200 = 0x00000400;
            const int BAUD_9600 = 0x00000800;
            const int BAUD_14400 = 0x00001000;
            const int BAUD_19200 = 0x00002000;
            const int BAUD_38400 = 0x00004000;
            const int BAUD_56K = 0x00008000;
            const int BAUD_57600 = 0x00040000;
            const int BAUD_115200 = 0x00020000;
            const int BAUD_128K = 0x00010000;

            _baudRateCollection.Clear();

            if ((possibleBaudRates & BAUD_075) > 0)
                _baudRateCollection.Add(75);
            if ((possibleBaudRates & BAUD_110) > 0)
                _baudRateCollection.Add(110);
            if ((possibleBaudRates & BAUD_150) > 0)
                _baudRateCollection.Add(150);
            if ((possibleBaudRates & BAUD_300) > 0)
                _baudRateCollection.Add(300);
            if ((possibleBaudRates & BAUD_600) > 0)
                _baudRateCollection.Add(600);
            if ((possibleBaudRates & BAUD_1200) > 0)
                _baudRateCollection.Add(1200);
            if ((possibleBaudRates & BAUD_1800) > 0)
                _baudRateCollection.Add(1800);
            if ((possibleBaudRates & BAUD_2400) > 0)
                _baudRateCollection.Add(2400);
            if ((possibleBaudRates & BAUD_4800) > 0)
                _baudRateCollection.Add(4800);
            if ((possibleBaudRates & BAUD_7200) > 0)
                _baudRateCollection.Add(7200);
            if ((possibleBaudRates & BAUD_9600) > 0)
                _baudRateCollection.Add(9600);
            if ((possibleBaudRates & BAUD_14400) > 0)
                _baudRateCollection.Add(14400);
            if ((possibleBaudRates & BAUD_19200) > 0)
                _baudRateCollection.Add(19200);
            if ((possibleBaudRates & BAUD_38400) > 0)
                _baudRateCollection.Add(38400);
            if ((possibleBaudRates & BAUD_56K) > 0)
                _baudRateCollection.Add(56000);
            if ((possibleBaudRates & BAUD_57600) > 0)
                _baudRateCollection.Add(57600);
            if ((possibleBaudRates & BAUD_115200) > 0)
                _baudRateCollection.Add(115200);
            if ((possibleBaudRates & BAUD_128K) > 0)
                _baudRateCollection.Add(128000);

            SendPropertyChangedEvent("BaudRateCollection");
            BaudRateCollectionUpdateHandler();
        }

        /**
         * @brief Send a PropertyChanged event.
         * @param[in] propertyName : name of changed property
         */
        private void SendPropertyChangedEvent(String propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion
    }
}
