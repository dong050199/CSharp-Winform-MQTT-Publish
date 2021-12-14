using System;
using System.Windows.Forms;

namespace MQTTTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        MQTT_Publish MqttClientPub = new MQTT_Publish();
        Data_MQTT_Publish datapub = new Data_MQTT_Publish();

        private void bt_Pub_Click(object sender, EventArgs e)
        {
            datapub.data1 = Convert.ToInt32(tb_data1.Text);
            datapub.data2 = Convert.ToInt32(tb_data2.Text);
            datapub.data3 = Convert.ToInt32(tb_data3.Text);
            datapub.data4 = Convert.ToInt32(tb_data4.Text);
            Console.WriteLine(datapub);
            MqttClientPub.MQTT_PublishObject("103.82.22.121", 1883, "donng", "dong123", "username_here", "password_here", datapub);
        }
    }
}
