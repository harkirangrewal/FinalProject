using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bitmapImage;
        Color[,] ImageArray = new Color[320, 240];

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //   openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyPictures);
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.Title = "Image Browser";


            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    Image newImage = Image.FromStream(myStream);
                    bitmapImage = new Bitmap(newImage, 320, 240);
                    picImage.Image = bitmapImage;
                    myStream.Close();
                }
            }

            SetArayFromBitmap();

        }
        private void SetBitmapFromAray()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    bitmapImage.SetPixel(row, col, ImageArray[row, col]);
                }
        }

        private void SetArayFromBitmap()
        {
            for (int row = 0; row < 320; row++)
                for (int col = 0; col < 240; col++)
                {
                    ImageArray[row, col] = bitmapImage.GetPixel(row, col);
                }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            Byte Red, Green, Blue;

            int Width = 320;
            int Height = 240;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Color col = ImageArray[i, j];

                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Color newColor = Color.FromArgb(255, (255 - Red), (255 - Green), (255 - Blue));
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
            //Figure out how to restore the image, after each transformation
        }

        private void btnLighten_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int Red, Green, Blue;

            int Width = 320;
            int Height = 240;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Color col = ImageArray[i, j];

                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Red = (Red + 30);
                    Green = (Green + 30);
                    Blue = (Blue + 30);


                    if (Red > 255)
                    {
                        Red = 255;
                    }

                    if (Green > 255)
                    {
                        Green = 255;
                    }

                    if (Blue > 255)
                    {
                        Blue = 255;
                    }

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnDarken_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int Red, Green, Blue;

            int Width = 320;
            int Height = 240;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Color col = ImageArray[i, j];

                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Red = (Red - 30);
                    Green = (Green - 30);
                    Blue = (Blue - 30);


                    if (Red < 0)
                    {
                        Red = 0;
                    }

                    if (Green < 0)
                    {
                        Green = 0;
                    }

                    if (Blue < 0)
                    {
                        Blue = 0;
                    }

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            }


            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnSunset_Effect_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int Red, Green, Blue;

            int Width = 320;
            int Height = 240;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Color col = ImageArray[i, j];

                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    Red = (Red + 40);
                    Blue = (Blue - 50);

                    if (Red > 255)
                    {
                        Red = 255;
                    }
                    if (Blue < 0)
                    {
                        Blue = 0;
                    }

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnPolarize_Click(object sender, EventArgs e)
        {
            // Two double loops, averages of red, green and blue of entire image (divide by the number of pixels)

            // Two more double loops, to compare the pixel, if the pixel is greater than the average, make it 255
            // If it is less than the average of the image, set it to 0

            if (bitmapImage == null)
                return;

            int Red, Green, Blue, avg_red, avg_green, avg_blue, num_pixels;
            avg_red = 0;
            avg_green = 0;
            avg_blue = 0;

            num_pixels = 320 * 240;

            int Width = 320;
            int Height = 240;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Color col = ImageArray[i, j];

                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    avg_red = (avg_red + Red);
                    avg_green = (avg_green + Green);
                    avg_blue = (avg_blue + Blue);
                }
            }

            avg_red = (avg_red / num_pixels);
            avg_blue = (avg_blue / num_pixels);
            avg_green = (avg_green / num_pixels);

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Color col = ImageArray[i, j];
                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    if (Red > avg_red)
                    {
                        Red = 225;
                    }

                    if (Red < avg_red)
                    {
                        Red = 0;
                    }

                    if (Green > avg_green)
                    {
                        Green = 255;
                    }

                    if (Green < avg_green)
                    {
                        Green = 0;
                    }

                    if (Blue > avg_blue)
                    {
                        Blue = 225;
                    }

                    if (Blue < avg_blue)
                    {
                        Blue = 0;
                    }

                    Color newColor = Color.FromArgb(255, Red, Green, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btngray_scale_Click(object sender, EventArgs e)
        {
            // Find average of each pixel's R G and B values 
            // Save that average into one color value, that one color value gets outputted for the one pixel

            if (bitmapImage == null)
                return;

            int Red, Green, Blue, avg_gray;

            int Width = 320;
            int Height = 240;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Color col = ImageArray[i, j];

                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    avg_gray = (Red + Green + Blue) / 3;

                    Red = avg_gray;
                    Green = avg_gray;
                    Blue = avg_gray;

                    Color newColor = Color.FromArgb(225, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int Green;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    Green = col.G;

                    Color newColor = Color.FromArgb(255, 0, Green, 0);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int Red;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    Red = col.R;

                    Color newColor = Color.FromArgb(255, Red, 0, 0);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int Blue;

            int iWidth = 320;
            int iHeight = 240;

            for (int i = 0; i < iWidth; i++)
            {
                for (int j = 0; j < iHeight; j++)
                {
                    Color col = ImageArray[i, j];

                    Blue = col.B;

                    Color newColor = Color.FromArgb(255, 0, 0, Blue);
                    ImageArray[i, j] = newColor;

                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;


        }

        private void btnHorizontalFlip_Click(object sender, EventArgs e)
        {
            // You are flipping pixels in the image, do not retrive/manipulate any of the colors
            // Make another pixel called "temp" save the left side pixel in temp
            // Set the left side pixel equal to the right side pixel
            // Save temp in the right side pixel
            // array [ i, j-9]

            // a 180 degree rotation is horizontal flip, followed by vertical

            int iWidth, iHeight, i, j;
            Color temp;

            if (bitmapImage == null)
                return;

            iWidth = 320;
            iHeight = 240;

            for (i = 0; i < (iWidth / 2); i++)
            {
                for (j = 0; j < iHeight; j++)
                {
                    temp = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[(319 - i), j];
                    ImageArray[(319 - i), j] = temp;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnFlipvertically_Click(object sender, EventArgs e)
        {
            int iWidth, iHeight, i, j;
            Color temp;

            if (bitmapImage == null)
                return;

            iWidth = 320;
            iHeight = 240;

            for (i = 0; i < iWidth; i++)
            {
                for (j = 0; j < (iHeight / 2); j++)
                {
                    temp = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[i, (239 - j)];
                    ImageArray[i, (239 - j)] = temp;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            int iWidth, iHeight, i, j;
            Color temp;

            if (bitmapImage == null)
                return;

            iWidth = 320;
            iHeight = 240;

            // From Horizontal Flip
            for (i = 0; i < (iWidth / 2); i++)
            {
                for (j = 0; j < iHeight; j++)
                {
                    temp = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[(319 - i), j];
                    ImageArray[(319 - i), j] = temp;
                }
            }

            // From Vertical flip
            for (i = 0; i < iWidth; i++)
            {
                for (j = 0; j < (iHeight / 2); j++)
                {
                    temp = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[i, (239 - j)];
                    ImageArray[i, (239 - j)] = temp;
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnBlur_Click(object sender, EventArgs e)
        {
            int iWidth, iHeight, i, j, avg_red, avg_green, avg_blue;
            Color[,] temp_array = new Color[320, 240];


            if (bitmapImage == null)
                return;

            iWidth = 320;
            iHeight = 240;

            for (i = 0; i < iWidth; i++)
            {
                for (j = 0; j < iHeight; j++)
                {

                    // Pixel case #1 - top left corner of array
                    if (i == 0 && j == 0)
                    {
                        avg_red = ((ImageArray[i, j].R + ImageArray[i + 1, j].R + ImageArray[i + 1, j + 1].R + ImageArray[i, j + 1].R) / 4);
                        avg_green = ((ImageArray[i, j].G + ImageArray[i + 1, j].G + ImageArray[i + 1, j + 1].G + ImageArray[i, j + 1].G) / 4);
                        avg_blue = ((ImageArray[i, j].B + ImageArray[i + 1, j].B + ImageArray[i + 1, j + 1].B + ImageArray[i, j + 1].B) / 4);

                        Color newColor = Color.FromArgb(225, avg_red, avg_green, avg_blue);
                        temp_array[i, j] = newColor;
                    }

                    // Pixel case #2- top right corner of array
                    else if (i == 319 && j == 0)
                    {
                        avg_red = ((ImageArray[i, j].R + ImageArray[i, j + 1].R + ImageArray[i - 1, j + 1].R + ImageArray[i - 1, j].R) / 4);
                        avg_green = ((ImageArray[i, j].G + ImageArray[i, j + 1].G + ImageArray[i - 1, j + 1].G + ImageArray[i - 1, j].G) / 4);
                        avg_blue = ((ImageArray[i, j].B + ImageArray[i, j + 1].B + ImageArray[i - 1, j + 1].B + ImageArray[i - 1, j].B) / 4);

                        Color newColor = Color.FromArgb(225, avg_red, avg_green, avg_blue);
                        temp_array[i, j] = newColor;
                    }

                    //Pixel case #4- bottom right corner of array
                    else if (i == 319 && j == 239)
                    {
                        avg_red = ((ImageArray[i, j].R + ImageArray[i, j - 1].R + ImageArray[i - 1, j - 1].R + ImageArray[i - 1, j].R) / 4);
                        avg_green = ((ImageArray[i, j].G + ImageArray[i, j - 1].G + ImageArray[i - 1, j - 1].G + ImageArray[i - 1, j].G) / 4);
                        avg_blue = ((ImageArray[i, j].B + ImageArray[i, j - 1].B + ImageArray[i - 1, j - 1].B + ImageArray[i - 1, j].B) / 4);

                        Color newColor = Color.FromArgb(225, avg_red, avg_green, avg_blue);
                        temp_array[i, j] = newColor;
                    }

                    // Pixel case #6- bottom left corner of array
                    else if (i == 0 && j == 239)
                    {
                        avg_red = ((ImageArray[i, j].R + ImageArray[i + 1, j].R + ImageArray[i + 1, j - 1].R + ImageArray[i, j - 1].R) / 4);
                        avg_green = ((ImageArray[i, j].G + ImageArray[i + 1, j].G + ImageArray[i + 1, j - 1].G + ImageArray[i, j - 1].G) / 4);
                        avg_blue = ((ImageArray[i, j].B + ImageArray[i + 1, j].B + ImageArray[i + 1, j - 1].B + ImageArray[i, j - 1].B) / 4);

                        Color newColor = Color.FromArgb(225, avg_red, avg_green, avg_blue);
                        temp_array[i, j] = newColor;

                    }
                    // Pixel case #3 - top row of array   


                    else if (j == 0)
                    {
                        avg_red = ((ImageArray[i, j].R + ImageArray[i + 1, j].R + ImageArray[i + 1, j + 1].R + ImageArray[i, j + 1].R + ImageArray[i - 1, j + 1].R + ImageArray[i - 1, j].R) / 6);
                        avg_green = ((ImageArray[i, j].G + ImageArray[i + 1, j].G + ImageArray[i + 1, j + 1].G + ImageArray[i, j + 1].G + ImageArray[i - 1, j + 1].G + ImageArray[i - 1, j].G) / 6);
                        avg_blue = ((ImageArray[i, j].B + ImageArray[i + 1, j].B + ImageArray[i + 1, j + 1].B + ImageArray[i, j + 1].B + ImageArray[i - 1, j + 1].B + ImageArray[i - 1, j].B) / 6);

                        Color newColor = Color.FromArgb(225, avg_red, avg_green, avg_blue);
                        temp_array[i, j] = newColor;
                    }



                    // Pixel case #5- furthest right column
                    else if (i == 319)
                    {
                        avg_red = ((ImageArray[i, j].R + ImageArray[i, j - 1].R + ImageArray[i - 1, j - 1].R + ImageArray[i - 1, j].R + ImageArray[i - 1, j + 1].R + ImageArray[i, j + 1].R) / 6);
                        avg_green = ((ImageArray[i, j].G + ImageArray[i, j - 1].G + ImageArray[i - 1, j - 1].G + ImageArray[i - 1, j].G + ImageArray[i - 1, j + 1].G + ImageArray[i, j + 1].G) / 6);
                        avg_blue = ((ImageArray[i, j].B + ImageArray[i, j - 1].B + ImageArray[i - 1, j - 1].B + ImageArray[i - 1, j].B + ImageArray[i - 1, j + 1].B + ImageArray[i, j + 1].B) / 6);

                        Color newColor = Color.FromArgb(225, avg_red, avg_green, avg_blue);
                        temp_array[i, j] = newColor;
                    }



                    //Pixel case #7- bottom row of array
                    else if (j == 239)
                    {
                        avg_red = ((ImageArray[i, j].R + ImageArray[i + 1, j].R + ImageArray[i + 1, j - 1].R + ImageArray[i, j - 1].R + ImageArray[i - 1, j - 1].R + ImageArray[i - 1, j].R) / 6);
                        avg_green = ((ImageArray[i, j].G + ImageArray[i + 1, j].G + ImageArray[i + 1, j - 1].G + ImageArray[i, j - 1].G + ImageArray[i - 1, j - 1].G + ImageArray[i - 1, j].G) / 6);
                        avg_blue = ((ImageArray[i, j].B + ImageArray[i + 1, j].B + ImageArray[i + 1, j - 1].B + ImageArray[i, j - 1].B + ImageArray[i - 1, j - 1].B + ImageArray[i - 1, j].B) / 6);

                        Color newColor = Color.FromArgb(225, avg_red, avg_green, avg_blue);
                        temp_array[i, j] = newColor;

                    }

                    // Pixel case #8- furthest left column of array
                    else if (i == 0)
                    {
                        avg_red = ((ImageArray[i, j].R + ImageArray[i, j - 1].R + ImageArray[i + 1, j - 1].R + ImageArray[i + 1, j].R + ImageArray[i + 1, j + 1].R + ImageArray[i, j + 1].R) / 6);
                        avg_green = ((ImageArray[i, j].G + ImageArray[i, j - 1].G + ImageArray[i + 1, j - 1].G + ImageArray[i + 1, j].G + ImageArray[i + 1, j + 1].G + ImageArray[i, j + 1].G) / 6);
                        avg_blue = ((ImageArray[i, j].B + ImageArray[i, j - 1].B + ImageArray[i + 1, j - 1].B + ImageArray[i + 1, j].B + ImageArray[i + 1, j + 1].B + ImageArray[i, j + 1].B) / 6);

                        Color newColor = Color.FromArgb(225, avg_red, avg_green, avg_blue);
                        temp_array[i, j] = newColor;

                    }

                    else
                    {
                        avg_red = ((ImageArray[i, j].R + ImageArray[(i - 1), j].R + ImageArray[(i - 1), (j - 1)].R + ImageArray[i, (j - 1)].R + ImageArray[(i + 1), (j - 1)].R + ImageArray[(i + 1), j].R + ImageArray[(i + 1), (j + 1)].R + ImageArray[i, (j + 1)].R + ImageArray[(i - 1), (j + 1)].R) / 9);
                        avg_green = ((ImageArray[i, j].G + ImageArray[(i - 1), j].G + ImageArray[(i - 1), (j - 1)].G + ImageArray[i, (j - 1)].G + ImageArray[(i + 1), (j - 1)].G + ImageArray[(i + 1), j].G + ImageArray[(i + 1), (j + 1)].G + ImageArray[i, (j + 1)].G + ImageArray[(i - 1), (j + 1)].G) / 9);
                        avg_blue = ((ImageArray[i, j].B + ImageArray[(i - 1), j].B + ImageArray[(i - 1), (j - 1)].B + ImageArray[i, (j - 1)].B + ImageArray[(i + 1), (j - 1)].B + ImageArray[(i + 1), j].B + ImageArray[(i + 1), (j + 1)].B + ImageArray[i, (j + 1)].B + ImageArray[(i - 1), (j + 1)].B) / 9);

                        Color newColor = Color.FromArgb(225, avg_red, avg_green, avg_blue);
                        temp_array[i, j] = newColor;
                    }

                }
            }

            for (i = 0; i < iWidth; i++)
            {
                for (j = 0; j < iHeight; j++)
                {
                    ImageArray[i, j] = temp_array[i, j];
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            int iWidth, iHeight, i, j;

            if (bitmapImage == null)
                return;

            iWidth = 320;
            iHeight = 240;

            Color[,] temparray = new Color[320, 240];

            for (i = 0; i < iWidth / 2; i++)
            {
                for (j = 0; j < iHeight / 2; j++)
                {
                    temparray[i, j] = ImageArray[i, j];
                    ImageArray[i, j] = ImageArray[160 + i, 120 + j];
                    ImageArray[160 + i, 120 + j] = temparray[i, j];
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;

        }

        private void btn_sortred_Click(object sender, EventArgs e)
        {
            if (bitmapImage == null)
                return;

            int Red, Green, Blue, avg_gray;

            int Width = 320;
            int Height = 240;

            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Color col = ImageArray[i, j];

                    Red = col.R;
                    Green = col.G;
                    Blue = col.B;

                    avg_gray = (Red + Green + Blue) / 3;

                    Red = avg_gray;
                    Green = avg_gray;
                    Blue = avg_gray;

                    Color newColor = Color.FromArgb(225, Red, Green, Blue);
                    ImageArray[i, j] = newColor;
                }
            }

            Color Value;

            for (int row = 0; row < 240; row++)
            {
                for (int i = 1; i < 320; i++)
                {
                    // copy the element we want to insert in a temp variable
                    Value = ImageArray[i, row];

                    int k = i - 1;

                    // Inner Loop moving from R->L through the items to the
                    // left of the iValue in order to make room for insertion
                    while (k >= 0)
                    {
                        if (ImageArray[k, row].R > Value.R)

                            ImageArray[(k + 1), row] = ImageArray[k, row];
                        //move one space to the right
                        else
                            break;
                        k = k - 1;
                    }
                    ImageArray[k + 1, row] = Value; //insert the value in the correct location
                }
            }

            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnscrolldown_Click(object sender, EventArgs e)
        {
            int iWidth, iHeight, i, j;
            Color[,] Temparray = new Color[320, 240];

            if (bitmapImage == null)
                return;

            iWidth = 320;
            iHeight = 240;

            for (i = 0; i < iWidth; i++)
            {
                for (j = 0; j < iHeight; j++)
                {
                    if (j + 30 < 240)
                    {
                        Temparray[i, j + 30] = ImageArray[i, j];
                    }

                    else
                    {
                        Temparray[i, j - 210] = ImageArray[i, j];
                    }
                }
            }

            for (i = 0; i < iWidth; i++)
            {
                for (j = 0; j < iHeight; j++)
                {
                    ImageArray[i, j] = Temparray[i, j];
                }

            }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnScrollUp_Click(object sender, EventArgs e)
        {
            int iWidth, iHeight, i, j;
            Color[,] Temparray = new Color[320, 240];

            if (bitmapImage == null)
                return;

            iWidth = 320;
            iHeight = 240;

            for (i = 0; i < iWidth; i++)
            {
                for (j = 0; j < iHeight; j++)
                {
                    if (j + 210 < 240)
                    {
                        Temparray[i, j + 210] = ImageArray[i, j];
                    }

                    else
                    {
                        Temparray[i, j - 30] = ImageArray[i, j];
                    }
                }
            }

            for (i = 0; i < iWidth; i++)
            {
                for (j = 0; j < iHeight; j++)
                {
                    ImageArray[i, j] = Temparray[i, j];
                }

            }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnpixellate_Click(object sender, EventArgs e)
        {
            int iWidth, iHeight, i, j;

            if (bitmapImage == null)
                return;

            iWidth = 320;
            iHeight = 240;

            for (i = 0; i + 4 < iWidth; i = i + 4)
            {
                for (j = 0; j + 2 < iHeight; j = j + 2)
                {
                    ImageArray[i + 1, j] = ImageArray[i, j];
                    ImageArray[i + 2, j] = ImageArray[i, j];
                    ImageArray[i + 3, j] = ImageArray[i, j];
                    ImageArray[i, j + 1] = ImageArray[i, j];
                    ImageArray[i + 1, j + 1] = ImageArray[i, j];
                    ImageArray[i + 2, j + 1] = ImageArray[i, j];
                    ImageArray[i + 3, j + 1] = ImageArray[i, j];
                }
            }
            SetBitmapFromAray();
            picImage.Image = bitmapImage;
        }

        private void btnTile_Click(object sender, EventArgs e)
        {
            int iWidth, iHeight, i, j, r = 0, c = 0;

            Color[,] Temparray = new Color[320, 240];

            if (bitmapImage == null)
                return;

            iWidth = 320;
            iHeight = 240;

            // This loop takes the larger image, and gets it into a smaller tile (saved in temp array)
            for (i = 0; i < iWidth; i = i + 2)
            {
                for (j = 0; j < iHeight; j = j + 2)
                {
                    Temparray[c, r] = ImageArray[i, j];
                    r = r + 1;
                }
                r = 0;
                c = c + 1;
            }

            // The temp array is outputted into the image array
            for (i = 0; i < iWidth; i = i + 1)
            {
                for (j = 0; j < iHeight; j = j + 1)
                {
                    ImageArray[i, j] = Temparray[i, j];
                }
            }

            // For the horizontal flip
            for(i=0; i<160; i++)
            {
                for(j=0; j<120; j++)
                {
                    Temparray[319 - i, j] = Temparray[i, j];
                }
            }

            // For the vertical flip
            for(i=0; i <160; i++)
            {
                for(j=0; j<120; j++)
                {
                    Temparray[i, 239 - j] = Temparray[i, j];
                }
            }

            // For the rotation 
            for(i=0; i<160; i++)
            {
                for(j=0; j<120; j++)
                {
                    Temparray[319 - i, 239 - j] = Temparray[i, j];
                }
            }

            for (i = 0; i < iWidth; i = i + 1)
            {
                for (j = 0; j < iHeight; j = j + 1)
                {
                    ImageArray[i, j] = Temparray[i, j];
                }
            }           

            SetBitmapFromAray();
            picImage.Image = bitmapImage;

        }
    }
}









