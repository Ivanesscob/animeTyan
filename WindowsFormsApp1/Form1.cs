using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
        
    {
        string NamePerson = "";
        string Devis = "";
        string colorHair = "white";
        string Vaib = "smile";
        bool glasses = false;
        bool ears = false;
        private Timer timer;
        Random r = new Random();
        
        


        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();
            label6.Text = "  Девочка-анимешница волшебница\n" +
                " обладает удивительной силой магии и \n" +
                " отправляется в захватывающее\n путешествие," +
                " встречая разнообразные\n" +
                " волшебные существа и\n" +
                " разгадывая мистические загадки,\n" +
                " всегда готовая использовать\n" +
                " свои силы," +
                " чтобы защитить мир от зла\n" +
                " и раскрыть\n свое" +
                " истинное предназначение.";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            nameStats.Text = NamePerson;
            nameBox.Text = Devis;
            if (colorHair == "white")
            {
                if (glasses)
                {
                    if (ears)
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteSmileGlassesEars.jpg");    
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteSadneesGlassesEars.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteGrinGlassesEars.jpg");
                        }
                    }
                    else
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteSmileGlasses.jpg");
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteSadneesGlasses.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteGrinGlasses.jpg");
                        }
                    }

                }
                else
                {
                    if (ears)
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteSmileEars.jpg");
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteSadneesEars.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteGrinEars.jpg");
                        }
                    }
                    else
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteSmile.jpg");
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteSadnees.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/faceWhiteGrin.jpg");
                        }
                    }
                }

            }
            else if (colorHair == "brown")
            {
                if (glasses)
                {
                    if (ears)
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/facebrownSmileGlassesEars.jpg");
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/faceBrownSadnessGlassesEars.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/faceBrownGrinGlassesEars.jpg");
                        }
                    }
                    else
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/faceBrownSmileGlasses.jpg");
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/faceBrownSadnessGlasses.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/faceBrownGrinGlasses.jpg");
                        }
                    }

                }
                else
                {
                    if (ears)
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/faceBrownSmileEars.jpg");
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/faceBrownSadnessEars.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/faceBrownGrinEars.jpg");
                        }
                    }
                    else
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/faceBrownSmile.jpg");
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/faceBrownSadness.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/faceBrownGrin.jpg");
                        }
                    }
                }
           
            }
            else if (colorHair == "pink")
            {
                if (glasses)
                {
                    if (ears)
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkSmileGlassesEars.jpg");
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkSadnessGlassesEars.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkGrinGlassesEars.jpg");
                        }
                    }
                    else
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkSmileGlasses.jpg");
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkSadnessGlasses.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkGrinGlasses.jpg");
                        }
                    }

                }
                else
                {
                    if (ears)
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkSmileEars.jpg");
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkSadnessEars.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkGrinEars.jpg");
                        }
                    }
                    else
                    {
                        if (Vaib == "smile")
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkSmile.jpg");
                        }
                        else if (Vaib == "sadnees")
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkSadness.jpg");
                        }
                        else
                        {
                            faceBox.Image = new Bitmap("pictures/facePinkGrin.jpg");
                        }
                    }
                }
            }
            GC.Collect();
        }

       


 
        private void randomUp_Click(object sender, EventArgs e)
        {
           
            string[] clothes = { "pictures/blueTShirts.jpg",
            "pictures/greenTShirt.jpg",
            "pictures/leatherJacket.jpg",
            "pictures/redShirt.jpg",
            "pictures/redTShirt.jpg"};
            
            
            faceImg.Image = new Bitmap(clothes[r.Next(4)]);
        }

        private void randomDown_Click(object sender, EventArgs e)
        {
            string[] clothesdown = { "pictures/blackShorts.jpg",
            "pictures/bluePants.jpg",
            "pictures/blueShorts.jpg",
            "pictures/greenPants.jpg",
            "pictures/redPlants.jpg"};

            
            plantsImg.Image = new Bitmap(clothesdown[r.Next(4)]);
        }

        private void randomChores_Click(object sender, EventArgs e)
        {
            string[] boots = { "pictures/boots.jpg",
            "pictures/crocks.jpg",
            "pictures/naked.jpg",
            "pictures/realSneakers.jpg",
            "pictures/sneakers.jpg"};

            
            bootsImg.Image = new Bitmap(boots[r.Next(4)]);
        }

        private void checkBoxGloves_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGloves.Checked)
            {
                rightGlovesImg.Image = new Bitmap("pictures/glovesRight.jpg");
                leftGlovesImg.Image = new Bitmap("pictures/gloves.Leftjpg.jpg");
            }
            else
            {
                rightGlovesImg.Image = null;
                leftGlovesImg.Image = null;
            }
            

        }

        private void checkBoxCloud_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCloud.Checked)
            {
                cloudImg.Image = new Bitmap("pictures/clouds.jpg");
                
            }
            else
            {
                cloudImg.Image = null;
                
            }
        }

        private void checkBoxTable_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTable.Checked)
            {
                TableBox.Image = new Bitmap("pictures/table.jpg");
            }
            else { TableBox.Image = null; }
        }

        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxName.Checked)
            {
                nameBox.Visible = true;
            }
            else {  nameBox.Visible = false; }
        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            NamePerson = nameField.Text;
        }

        private void radioButtonRedTShirt_CheckedChanged(object sender, EventArgs e)
        {
            faceImg.Image = new Bitmap("pictures/redTShirt.jpg");
        }

        private void radioButtonGreenTShirt_CheckedChanged(object sender, EventArgs e)
        {
            faceImg.Image = new Bitmap("pictures/greenTShirt.jpg");
        }

        private void radioButtonRedShirt_CheckedChanged(object sender, EventArgs e)
        {
            faceImg.Image = new Bitmap("pictures/redShirt.jpg");
        }

        private void radioButtonBlueShirt_CheckedChanged(object sender, EventArgs e)
        {
            faceImg.Image = new Bitmap("pictures/blueTShirts.jpg");
            
        }

        private void radioButtonLeather_CheckedChanged(object sender, EventArgs e)
        {
            faceImg.Image = new Bitmap("pictures/leatherJacket.jpg");
        }

        private void radioButtonBlackShorts_CheckedChanged(object sender, EventArgs e)
        {
            plantsImg.Image = new Bitmap("pictures/blackShorts.jpg");
        }

        private void radioButtonBlueShorts_CheckedChanged(object sender, EventArgs e)
        {
            plantsImg.Image = new Bitmap("pictures/blueShorts.jpg");
        }

        private void radioButtonRedPants_CheckedChanged(object sender, EventArgs e)
        {
            plantsImg.Image = new Bitmap("pictures/redPlants.jpg");
        }

        private void radioButtonGreenPants_CheckedChanged(object sender, EventArgs e)
        {
            plantsImg.Image = new Bitmap("pictures/greenPants.jpg");
        }

        private void radioButtonBluePlants_CheckedChanged(object sender, EventArgs e)
        {
            plantsImg.Image = new Bitmap("pictures/bluePants.jpg");
        }

        private void radioButtonFlipFlops_CheckedChanged(object sender, EventArgs e)
        {
            bootsImg.Image = new Bitmap("pictures/sneakers.jpg");
        }

        private void radioButtonSneakers_CheckedChanged(object sender, EventArgs e)
        {
            bootsImg.Image = new Bitmap("pictures/boots.jpg");
        }

        private void radioButtonRealSneakers_CheckedChanged(object sender, EventArgs e)
        {
            bootsImg.Image = new Bitmap("pictures/realSneakers.jpg");
        }

        private void radioButtonCrocs_CheckedChanged(object sender, EventArgs e)
        {
            bootsImg.Image = new Bitmap("pictures/crocks.jpg");
        }

        private void radioButtonNaked_CheckedChanged(object sender, EventArgs e)
        {
            bootsImg.Image = new Bitmap("pictures/naked.jpg");
        }

        private void devisField_TextChanged(object sender, EventArgs e)
        {
            Devis = devisField.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            faceImg.Image = new Bitmap("pictures/greenTShirt.jpg");
            bootsImg.Image = new Bitmap("pictures/boots.jpg");
            plantsImg.Image = new Bitmap("pictures/greenPants.jpg");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bootsImg.Image = new Bitmap("pictures/naked.jpg");
            faceImg.Image = new Bitmap("pictures/blueTShirts.jpg");
            plantsImg.Image = new Bitmap("pictures/bluePants.jpg");
        }

        private void colorHairField_TextChanged(object sender, EventArgs e)
        {
            colorHair = colorHairField.Text.ToLower();
        }

        private void checkBoxEars_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEars.Checked)
            {
                glasses = true;
            }
            else
            {
                glasses = false;
            }
        }

        private void checkBoxGlosses_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGlosses.Checked)
            {
                ears = true;
            }
            else { ears = false; }
        }

        private void GrinButton_Click(object sender, EventArgs e)
        {
            Vaib = "grin";
        }

        private void SadnessButton_Click(object sender, EventArgs e)
        {
            Vaib = "sadnees";
        }

        private void SmileButton_Click(object sender, EventArgs e)
        {
            Vaib = "smile";
        }

        private void randomVaib_Click(object sender, EventArgs e)
        {
            string[] s = { "smile", "grin", "sadnees" };
            Vaib = s[r.Next(3)];
        }

       
    }
}
