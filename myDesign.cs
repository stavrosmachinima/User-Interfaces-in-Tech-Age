﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace allhlepidrash
{
    public partial class myDesign : Form
    {
        bool onlyKitchen=true;
        bool onlyLivingRoom = true;
        String temperatureKitchen ="27 °C";
        String temperatureLivingRoom= "33 °C";
        public myDesign()
        {
            InitializeComponent();
        }

        private void myDesign_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (onlyKitchen)
            {
                if (IconKitchenOn.Visible == true)
                {
                    onlyLivingRoom = true;
                    onlyKitchen = false;
                    LivingRoomOff.Visible = false;
                    LivingRoomOn.Visible = false;
                    kitchenOn.Visible = true;
                    kitchenOff.Visible = false;
                    button4.Visible = true;
                }
                else if (IconKitchenOff.Visible==true)
                {
                    onlyLivingRoom = true;
                    onlyKitchen = false;
                    LivingRoomOff.Visible = false;
                    LivingRoomOn.Visible = false;
                    kitchenOff.Visible = true;
                    kitchenOn.Visible = false;
                    button4.Visible = true;
                }
                temperature.Text =temperatureKitchen;
                temperature.Visible = true;
                increase.Visible = true;
                decrease.Visible = true;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            IconKitchenOn.Visible = false;
            IconKitchenOff.Visible = true;
            kitchenOn.Visible = false;
            kitchenOff.Visible = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            IconKitchenOn.Visible = true;
            kitchenOff.Visible = false;
            kitchenOn.Visible = true;
            IconKitchenOff.Visible =false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (onlyLivingRoom)
            {
                if (IconLivingRoomOn.Visible == true)
                {
                    onlyLivingRoom = false;
                    onlyKitchen = true;
                    kitchenOff.Visible = false;
                    kitchenOn.Visible = false;
                    LivingRoomOff.Visible = false;
                    LivingRoomOn.Visible = true;
                    button4.Visible = true;

                }
                else if(IconLivingRoomOff.Visible==true)
                {
                    onlyLivingRoom = false;
                    onlyKitchen = true;
                    kitchenOff.Visible = false;
                    kitchenOn.Visible = false;
                    LivingRoomOn.Visible = false;
                    LivingRoomOff.Visible = true;
                    button4.Visible = true;
                }
                temperature.Text = temperatureLivingRoom;
                temperature.Visible = true;
                increase.Visible = true;
                decrease.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kitchenOn.Visible == true)
            {
                IconKitchenOff.Visible = true;
                LivingRoomOff.Visible = false;
                LivingRoomOn.Visible = false;
                IconKitchenOn.Visible = false;
                kitchenOff.Visible = true;
                kitchenOn.Visible = false;
            }
            else if (kitchenOff.Visible == true)
            {
                LivingRoomOff.Visible = false;
                LivingRoomOn.Visible = false;
                IconKitchenOff.Visible = false;
                IconKitchenOn.Visible = true;
                kitchenOn.Visible = true;
                kitchenOff.Visible = false;
            }
            else if (LivingRoomOn.Visible == true)
            {
                kitchenOff.Visible = false;
                kitchenOn.Visible = false;
                LivingRoomOn.Visible = false;
                LivingRoomOff.Visible = true;

            }
            else if (LivingRoomOff.Visible == true)
            {
                kitchenOff.Visible = false;
                kitchenOn.Visible = false;
                LivingRoomOff.Visible = false;
                LivingRoomOn.Visible = true;

            }
        }

        private void IconLivingRoomOff_Click(object sender, EventArgs e)
        {
                IconLivingRoomOff.Visible = false;
                IconLivingRoomOn.Visible = true;
            if (kitchenOff.Visible == false && kitchenOn.Visible == false)
            {
                LivingRoomOff.Visible = false;
                LivingRoomOn.Visible = true;
            }
        }

        private void IconLivingRoomOn_Click(object sender, EventArgs e)
        {
                IconLivingRoomOn.Visible = false;
                IconLivingRoomOff.Visible = true;
            if (kitchenOff.Visible == false && kitchenOn.Visible == false)
            {
                LivingRoomOn.Visible = false;
                LivingRoomOff.Visible = true;

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            String s1 = temperature.Text;
            s1 = s1.Substring(0, 2);
            int add = int.Parse(s1);
            add = add + 1;
            s1 = add.ToString()+ " °C";
            temperature.Text = s1;
        }

        private void decrease_Click(object sender, EventArgs e)
        {
            String s1 = temperature.Text;
            s1 = s1.Substring(0, 2);
            int add = int.Parse(s1);
            add = add - 1;
            s1 = add.ToString() + " °C";
            temperature.Text = s1;
        }
    }
}
