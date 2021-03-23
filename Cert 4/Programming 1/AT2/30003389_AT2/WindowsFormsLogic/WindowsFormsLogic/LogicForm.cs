using System;
using System.Drawing;
using System.Windows.Forms;
// Kyer Potts
// 30003389 10/03/2019
// AT2 Pracical Assessment
namespace WindowsFormsLogic
{
    public partial class LogicForm : Form
    {
        public LogicForm()
        {
            InitializeComponent();
        }
        // false: light is OFF 
        // true: light is ON
        bool storage_room_Status = false;
        bool bedroom_1_Light_Status = false;
        bool bath_1_Light_Status = false;
        bool bedroom_2_Light_Status = false;
        bool bath_2_Light_Status = false;
        bool kitchen_Light_Status = false;
        bool passage_1_Light_Status = false;
        bool passage_2_Light_Status = false;
        bool dining_Light_Status = false;
        bool lounge_Light_Status = false;
        bool entrance_Light_Status = false;

        // switch the light on and off for the storage room
        // can youexplain the difference between bedroom two and storge room?
        private void Storage_Room_Switch_Click(object sender, EventArgs e)
        {
            if(storage_room_Status == false)
            {
                Storage_Room_Light.Image = Properties.Resources.on;
                storage_room_Status = true;
            }
            else
            {
                Storage_Room_Light.Image = Properties.Resources.off;
                storage_room_Status = false;
            }
        }
        
        // switch the light on and off for master bedroom
        // both lights are used together
        private void Bedroom_1_Switch_Click(object sender, EventArgs e)
        {
            if (bedroom_1_Light_Status)
            {
                Bedroom_1_Light_1A.Image = Properties.Resources.off;
                Bedroom_1_Light_1B.Image = Properties.Resources.off;
                bedroom_1_Light_Status = false;
            }
            else
            {
                Bedroom_1_Light_1A.Image = Properties.Resources.on;
                Bedroom_1_Light_1B.Image = Properties.Resources.on;
                bedroom_1_Light_Status = true;
            }
        }

        // switch the light on and off for bathroom one
        // can you explain the difference between bath one and bath two?
        // this method is used for two buttons
        private void Bath_1_Switch_Click(object sender, EventArgs e)
        {
            if (bath_1_Light_Status)
            {
                Bath_1_Light.Image = Properties.Resources.off;
                bath_1_Light_Status = false;
            }
            else
            {
                Bath_1_Light.Image = Properties.Resources.on;
                bath_1_Light_Status = true;
            }
        } 

        // master switch for bedroom two
        private void Master_Switch_Click(object sender, EventArgs e)
        {
            if (bedroom_1_Light_Status || bath_1_Light_Status)
            {
                // turn off all lights (two bedroom lights and bathroom light)
                Bath_1_Light.Image = Properties.Resources.off;
                bath_1_Light_Status = false;
                Bedroom_1_Light_1A.Image = Properties.Resources.off;
                Bedroom_1_Light_1B.Image = Properties.Resources.off;
                bedroom_1_Light_Status = false;
            }
            else
            {
                // turn on one light (one bedroom light)
                Bedroom_1_Light_1A.Image = Properties.Resources.on;
                bedroom_1_Light_Status = true;
            }
        }

        // switch the light on and off for bedroom two
        private void Bedroom_2_Switch_Click(object sender, EventArgs e)
        {
            if (bedroom_2_Light_Status)
            {
                Bedroom_2_Light.Image = Properties.Resources.off;
                bedroom_2_Light_Status = false;
            }
            else
            {
                Bedroom_2_Light.Image = Properties.Resources.on;
                bedroom_2_Light_Status = true;
            }
        }
     
        // switch the light on and off for bathroom two
        private void Bath_2_Switch_Click(object sender, EventArgs e)
        {
            if (!(bath_2_Light_Status))
            {
                Bath_2_Light.Image = Properties.Resources.on;
                bath_2_Light_Status = true;
            }
            else
            {
                Bath_2_Light.Image = Properties.Resources.off;
                bath_2_Light_Status = false;
            }
        }

        // switch the light on and off for kitchen
        private void Kitchen_Switch_Click(object sender, EventArgs e)
        {
            if (kitchen_Light_Status)
            {
                Kitchen_Light.Image = Properties.Resources.off;
                kitchen_Light_Status = false;
            }
            else
            {
                Kitchen_Light.Image = Properties.Resources.on;
                kitchen_Light_Status = true;
            }
        }

        // switch for lights in passage_1 switch
        private void Passage_1_Switch_Click(object sender, EventArgs e)
        {
            if (passage_1_Light_Status || passage_2_Light_Status)
            {             
                Passage_Light_1A.Image = Properties.Resources.off;
                Passage_Light_1B.Image = Properties.Resources.off;
                Passage_Light_2.Image = Properties.Resources.off;
                passage_1_Light_Status = false;
                passage_2_Light_Status = false;
            }
            else if(passage_1_Light_Status)
            {
                Passage_Light_1A.Image = Properties.Resources.off;
                Passage_Light_1B.Image = Properties.Resources.off;
                passage_1_Light_Status = false;
            }
            else
            {
                Passage_Light_1A.Image = Properties.Resources.on;
                Passage_Light_1B.Image = Properties.Resources.on;
                passage_1_Light_Status = true;
            }
        }

        // switch for lights in passage_2 switch
        private void Passage_2_Switch_Click(object sender, EventArgs e)
        {
            //  PassageLight_2 OFF && PassageLight_1 ON
            if(!(passage_2_Light_Status) && passage_1_Light_Status )
            {
                // Turn on PassageLight
                Passage_Light_1A.Image = Properties.Resources.on;
                Passage_Light_1B.Image = Properties.Resources.on;
                Passage_Light_2.Image = Properties.Resources.on;
                passage_1_Light_Status = true;
                passage_2_Light_Status = true;
            }
            // PassageLight_2 ON && PassageLight_1 ON
            else if(passage_2_Light_Status && passage_1_Light_Status)
            {
                Passage_Light_1A.Image = Properties.Resources.off;
                Passage_Light_1B.Image = Properties.Resources.off;
                Passage_Light_2.Image = Properties.Resources.off;
                passage_1_Light_Status = false;
                passage_2_Light_Status = false;
            }
            else
            {                                             
                Passage_Light_1A.Image = Properties.Resources.on;
                Passage_Light_1B.Image = Properties.Resources.on;
                Passage_Light_2.Image = Properties.Resources.on;
                passage_1_Light_Status = true;
                passage_2_Light_Status = true;
            }
        }
        
        // switch the light on and off for dining room
        private void Dining_Switch_Click(object sender, EventArgs e)
        {   
            //turn off dining room light
            if (dining_Light_Status)
            {
                Dining_Light.Image = Properties.Resources.off;
                dining_Light_Status = false;
            }
            //turn on dining room light
            else
            {
                Dining_Light.Image = Properties.Resources.on;
                dining_Light_Status = true;
            }
        }


        private void Lounge_Switch_Click(object sender, EventArgs e)
        {   
            //turn off dining, lounge and entrance light if any are on
            if(dining_Light_Status || lounge_Light_Status || entrance_Light_Status)
            {
                Dining_Light.Image = Properties.Resources.off;
                Lounge_Light.Image = Properties.Resources.off;
                Entrance_Light.Image = Properties.Resources.off;
                dining_Light_Status = false;
                lounge_Light_Status = false;
                entrance_Light_Status = false;
            }
            //turn on dining and lounge light
            else
            {
                Dining_Light.Image = Properties.Resources.on;
                Lounge_Light.Image = Properties.Resources.on;
                dining_Light_Status = true;
                lounge_Light_Status = true;
            }
        }

        // switch the lights in the dining and entrance on and off
        private void Entrance_Switch_Click(object sender, EventArgs e)
        {   // turn on entrance light and dining light
            if(!(entrance_Light_Status) && !(dining_Light_Status))
            {
                Entrance_Light.Image = Properties.Resources.on;
                Dining_Light.Image = Properties.Resources.on;
                entrance_Light_Status = true;
                dining_Light_Status = true;
            }
            // turn on entrance light
            else if (!(entrance_Light_Status))
            {
                Entrance_Light.Image = Properties.Resources.on;
                entrance_Light_Status = true;
            }
            // turn off entrance light only
            else
            {
                Entrance_Light.Image = Properties.Resources.off;
                entrance_Light_Status = false;
            }
            
        }
    }
}
