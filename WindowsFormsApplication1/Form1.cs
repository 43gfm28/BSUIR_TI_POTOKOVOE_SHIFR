using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        byte ConvertByte(BitArray bits)
        {
            byte[] bytes = new byte[1];
            bits.CopyTo(bytes, 0);
            return bytes[0];
        }

        int[] lfsr1;
        int[] lfsr2;
        int[] lfsr3;
        string result = "";
        string begin1 = "";
        string begin2 = "";
        string begin3 = " ";
        string filename = "";
        //шифровка
        private void button_shifr_Click(object sender, EventArgs e)
        {
            begin1 = textBox_lsfr1.Text;
            begin2 = textBox_lsfr2.Text;
            begin3 = textBox_lsfr3.Text;
            string path_key1 = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\ключ в двоичном.txt";
            string path_shift = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\зашифрованное\\файлик";
            string path_textthift = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\зашифрованный вид.txt";
            if (begin1.Length != 25)
            {
                MessageBox.Show("Ключ будет равен всем единицам", "Длина ключа 1 неверная");
                begin1 = "1111111111111111111111111";
            }


            lfsr1 = new int[25];
            for (int i = 0; i < 25; i++)
            {

                lfsr1[i] = Convert.ToInt32(Convert.ToString(begin1[i]));
            }
            begin1 = "";
            for (int i = 0; i < bytes.Length ; i++)
            {
                begin1 += Convert.ToString(lfsr1[24]);

                int xor = lfsr1[2] ^ lfsr1[24];


                for (int q = 24; q > 0; q--)
                {
                    lfsr1[q] = lfsr1[q - 1];

                }
                lfsr1[0] = xor;
            }

            File.WriteAllText(path_key1, begin1);

            for (int i = 0; i < begin1.Length; i++)
            {
                int a = Convert.ToInt32(Convert.ToString(begin1[i]));
                int b = Convert.ToInt32(Convert.ToString(bytes[i]));
                int xor = a ^ b;
                result += Convert.ToString(xor);
            }
            File.WriteAllText(path_textthift, result);

            //  File.WriteAllText(path_shift + extension, result);

            using (BinaryWriter writerbin1 = new BinaryWriter(File.Create(path_shift + extension)))
            {
                int j = 0;
                bool[] arr = new bool[8];
                for (int i = 0; i < bytes.Length; i++)
                {
                    bool buf1, buf2;
                    buf1 = bytes[i] == '1' ? true : false;
                    buf2 = begin1[i] == '1' ? true : false;
                    arr[i % 8] = (buf1 ^ buf2);
                    j++;
                    if (j == 8)
                    {
                        BitArray bitarray = new BitArray(new bool[] { arr[7], arr[6], arr[5], arr[4], arr[3], arr[2], arr[1], arr[0] });
                        byte n = ConvertByte(bitarray);
                        j = 0;
                        writerbin1.Write(n);
                    }
                }
            }



        }

        string bytes = "";
        string extension;
        //открытие файла для шифровки
        private void button2_Click(object sender, EventArgs e)
        {
            string path = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\шифруем\\";
            string path2 = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\двоичный вид файла.txt";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            filename = openFileDialog1.FileName;
            //читаем файл побайтово
            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    // bytes = bytes + reader.ReadByte();
                    byte a = reader.ReadByte();
                    BitArray bit1 = new BitArray(new byte[] { a });
                    for (int i = bit1.Length - 1; i >= 0; i--)
                    {
                        bytes += bit1[i] == true ? "1" : "0";
                    }
                }

                // textBox1.Text = bytes;
            }


            File.WriteAllText(path2, bytes);
            extension = Path.GetExtension(filename);




        }

        //расшифровка
        string bytes_shifr = "";
        string rashivrovk = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string path_rashivr = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\расшифрованное\\файлик";
            using (BinaryWriter writerbin2 = new BinaryWriter(File.Create(path_rashivr + extension2)))
            {
                int j = 0;
                bool[] arr = new bool[8];
                for (int i = 0; i < bytes.Length; i++)
                {
                    bool buf1, buf2;
                    buf1 = bytes_shifr[i] == '1' ? true : false;
                    buf2 = begin1[i] == '1' ? true : false;
                    arr[i % 8] = (buf1 ^ buf2);
                    j++;
                    if (j == 8)
                    {
                        BitArray bitarray = new BitArray(new bool[] { arr[7], arr[6], arr[5], arr[4], arr[3], arr[2], arr[1], arr[0] });
                        byte n = ConvertByte(bitarray);
                        j = 0;
                        writerbin2.Write(n);
                    }
                }
            }
        }

        //открываем текст для расшифровки

        string extension2;
        string filename2;
        private void button3_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            filename2 = openFileDialog1.FileName;
            //читаем файл побайтово
            using (BinaryReader reader2 = new BinaryReader(File.Open(filename2, FileMode.Open)))
            {
                while (reader2.BaseStream.Position != reader2.BaseStream.Length)
                {
                    // bytes = bytes + reader.ReadByte();
                    byte a = reader2.ReadByte();
                    BitArray bit2 = new BitArray(new byte[] { a });
                    for (int i = bit2.Length - 1; i >= 0; i--)
                    {
                        bytes_shifr += bit2[i] == true ? "1" : "0";
                    }
                }

                extension2 = Path.GetExtension(filename2);
            }



        }
        //ШИФРОВКА ГЕФФЕ
        string multipl = "";
        private void button7_Click(object sender, EventArgs e)
        {
            begin1 = textBox_lsfr1.Text;
            begin2 = textBox_lsfr2.Text;
            begin3 = textBox_lsfr3.Text;
            if (begin1.Length != 25)
            {
                MessageBox.Show("Ключ будет равен всем единицам", "Длина ключа 1 неверная");
                begin1 = "1111111111111111111111111";
            }
            if (begin2.Length != 33)
            {
                MessageBox.Show("Ключ будет равен всем единицам", "Длина ключа 2 неверная");
                begin2 = "111111111111111111111111111111111";
            }
            if (begin3.Length != 23)
            {
                MessageBox.Show("Ключ будет равен всем единицам", "Длина ключа 3 неверная");
                begin3 = "11111111111111111111111";
            }
            string path_key1 = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\ключ в двоичном.txt";
            string path_shift = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\зашифрованное\\файлик";
            string path_textthift = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\зашифрованный вид.txt";
            string path1 = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\1.txt";
            string path2 = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\2.txt";
            string path3 = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\3.txt";


            lfsr1 = new int[25];
            for (int i = 0; i < 25; i++)
            {

                lfsr1[i] = Convert.ToInt32(Convert.ToString(begin1[i]));
            }

            begin1 = "";
            for (int i = 0; i < bytes.Length ; i++)
            {
                begin1 += Convert.ToString(lfsr1[24]);

                int xor = lfsr1[2] ^ lfsr1[24];


                for (int q = 24; q > 0; q--)
                {
                    lfsr1[q] = lfsr1[q - 1];

                }
                lfsr1[0] = xor;
            }

            File.WriteAllText(path1, begin1);

            //ВТОРОЙ КЛЮЧИК
            lfsr2 = new int[33];
            for (int i = 0; i < 33; i++)
            {

                lfsr2[i] = Convert.ToInt32(Convert.ToString(begin2[i]));
            }
            begin2 = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                begin2 += Convert.ToString(lfsr2[32]);

                int xor = lfsr2[12] ^ lfsr2[32];


                for (int q = 32; q > 0; q--)
                {
                    lfsr2[q] = lfsr2[q - 1];

                }
                lfsr2[0] = xor;
            }

            File.WriteAllText(path2, begin2);

            //ТРЕТИЙ КЛЮЧИК
            lfsr3 = new int[23];
            for (int i = 0; i < 23; i++)
            {

                lfsr3[i] = Convert.ToInt32(Convert.ToString(begin3[i]));
            }
            begin3 = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                begin3 += Convert.ToString(lfsr3[22]);

                int xor = lfsr3[4] ^ lfsr3[22];


                for (int q = 22; q > 0; q--)
                {
                    lfsr3[q] = lfsr3[q - 1];

                }
                lfsr3[0] = xor;
            }

            File.WriteAllText(path3, begin3);

            //мультеплексорик

            int x1, x2, x3, xg, a, b, c;
            for (int i = 0; i < begin1.Length; i++)
            {
                x1 = Convert.ToInt32(Convert.ToString(begin1[i]));
                x2 = Convert.ToInt32(Convert.ToString(begin2[i]));
                x3 = Convert.ToInt32(Convert.ToString(begin3[i]));

                if (x1 == 1 & x2 == 1)
                {
                    a = 1;
                }
                else
                {
                    a = 0;
                }
                if (x1 == 1)
                {
                    b = 0;
                }
                else
                {
                    b = 1;
                }

                if (b == 1 & x3 == 1)
                {
                    c = 1;
                }
                else
                {
                    c = 0;
                }
                if (a == 0 & c == 0)
                {
                    xg = 0;
                }
                else
                {
                    xg = 1;
                }
                multipl += Convert.ToString(xg);
            }
            File.WriteAllText(path_key1, multipl);


            result = "";
            for (int i = 0; i < begin1.Length; i++)
            {
                int a1 = Convert.ToInt32(Convert.ToString(multipl[i]));
                int b1 = Convert.ToInt32(Convert.ToString(bytes[i]));
                int xor = a1 ^ b1;
                result += Convert.ToString(xor);
            }
            File.WriteAllText(path_textthift, result);

            //  File.WriteAllText(path_shift + extension, result);

            using (BinaryWriter writerbin1 = new BinaryWriter(File.Create(path_shift + extension)))
            {
                int j = 0;
                bool[] arr = new bool[8];
                for (int i = 0; i < bytes.Length; i++)
                {
                    bool buf1, buf2;
                    buf1 = bytes[i] == '1' ? true : false;
                    buf2 = multipl[i] == '1' ? true : false;
                    arr[i % 8] = (buf1 ^ buf2);
                    j++;
                    if (j == 8)
                    {
                        BitArray bitarray = new BitArray(new bool[] { arr[7], arr[6], arr[5], arr[4], arr[3], arr[2], arr[1], arr[0] });
                        byte n = ConvertByte(bitarray);
                        j = 0;
                        writerbin1.Write(n);
                    }
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string path_rashivr = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\расшифрованное\\файлик";
            using (BinaryWriter writerbin2 = new BinaryWriter(File.Create(path_rashivr + extension2)))
            {
                int j = 0;
                bool[] arr = new bool[8];
                for (int i = 0; i < bytes.Length; i++)
                {
                    bool buf1, buf2;
                    buf1 = bytes_shifr[i] == '1' ? true : false;
                    buf2 = multipl[i] == '1' ? true : false;
                    arr[i % 8] = (buf1 ^ buf2);
                    j++;
                    if (j == 8)
                    {
                        BitArray bitarray = new BitArray(new bool[] { arr[7], arr[6], arr[5], arr[4], arr[3], arr[2], arr[1], arr[0] });
                        byte n = ConvertByte(bitarray);
                        j = 0;
                        writerbin2.Write(n);
                    }
                }
            }
        }
        //шифровка RC4
        string slovo;
        int[] S;
        private void button11_Click(object sender, EventArgs e)
        {
            string path_shift = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\зашифрованное\\файлик";
            string rc_path = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\RC4.txt";
            string rc_pathT = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\RC4_TEXT.txt";
            slovo = textBox1.Text;
            int length = slovo.Length;
            S = new int[256];
            int i = 0; int j = 0;
            for (i = 0; i < 256; i++)
            {
                S[i] = i;
            }
            string key = "";
            int[] keymas = new int[256];
            int z = 0;
            for (i = 0; i<slovo.Length; i++)
            {
                if (slovo[i] != ' ')
                {
                    key += slovo[i];

                }
                else
                {
                    keymas[z] = Convert.ToInt32(key);
                    key = "";
                    z++;
                }
            }
            j = 0; 
            for (i = 0; i < 256; i++)
            {
                j = (j + S[i] + keymas[i % z]) % 256;
                //swap(S[i], S[j]);
                int temp = S[j];
                S[j] = S[i];
                S[i] = temp;
                
            }
            string keyRC4 = "";
         
            //шифруем
            i = 0; j = 0; int k = 0; string text = "";
            using (BinaryReader reader = new BinaryReader(File.Open(filename, FileMode.Open)))
            {
                using (BinaryWriter writerbin1 = new BinaryWriter(File.Create(path_shift + extension)))
                { 
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {

                        byte a = reader.ReadByte();
                        int byte1 = Convert.ToInt32(a);
                        i = (i + 1) % 256;
                        j = (j + S[i]) % 256;
                        // swap(S[i], S[j]);
                        int temp = S[j];
                        S[j] = S[i];
                        S[i] = temp;
                        k = S[(S[i] + S[j]) % 256]; 
                        int byte2 = k ^ byte1;
                        text += Convert.ToString(byte2);
                        keyRC4+= Convert.ToString(k)+" ";
                        byte n = Convert.ToByte(byte2);
                        writerbin1.Write(n);
                    }

                    File.WriteAllText(rc_path, keyRC4);
                    File.WriteAllText(rc_pathT, text);

            }
        }
           

        }
        //расшифровка RC4
        private void button10_Click(object sender, EventArgs e)
        {
            string path_rashivr = "C:\\Users\\Не смотри\\Desktop\\потоковое шифрование\\WindowsFormsApplication1\\расшифрованное\\файлик";
            slovo = textBox1.Text;
            int length = slovo.Length;
            
              slovo = textBox1.Text;
          //  int length = slovo.Length;
            S = new int[256];
            int i = 0; int j = 0;
            for (i = 0; i < 256; i++)
            {
                S[i] = i;
            }
            string key = "";
            int[] keymas = new int[256];
            int z = 0;
            for (i = 0; i<slovo.Length; i++)
            {
                if (slovo[i] != ' ')
                {
                    key += slovo[i];

                }
                else
                {
                    keymas[z] = Convert.ToInt32(key);
                    key = "";
                    z++;
                }
            }
            j = 0; 
            for (i = 0; i < 256; i++)
            {
                j = (j + S[i] + keymas[i % z]) % 256;
                //swap(S[i], S[j]);
                int temp = S[j];
                S[j] = S[i];
                S[i] = temp;
                
            }
            
            /*
            S = new int[256];
            int i = 0; int j = 0;
            for (i = 0; i < 256; i++)
            {
                S[i] = i;
            }

            j = 0;
            for (i = 0; i < 256; i++)
            {
                j = (j + S[i] + Convert.ToInt32(Convert.ToString(slovo[i % length]))) % 256;
                //swap(S[i], S[j]);
                int temp = S[j];
                S[j] = S[i];
                S[i] = temp;
            }*/
            string keyRC4 = "";
            for (i = 0; i < 256; i++)
            {
                keyRC4 += Convert.ToString(S[i]) + " ";
            }
           
            //шифруем
            i = 0; j = 0; int k = 0; //string text = "";
            using (BinaryReader reader = new BinaryReader(File.Open(filename2, FileMode.Open)))
            {
                using (BinaryWriter writerbin1 = new BinaryWriter(File.Create(path_rashivr + extension2)))
                {
                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {

                        byte a = reader.ReadByte();
                        int byte1 = Convert.ToInt32(a);
                        i = (i + 1) % 256;
                        j = (j + S[i]) % 256;
                        // swap(S[i], S[j]);
                        int temp = S[j];
                        S[j] = S[i];
                        S[i] = temp;
                        k = S[(S[i] + S[j]) % 256];
                        int byte2 = k ^ byte1;
                     //   text += Convert.ToString(byte2);
                        byte n = Convert.ToByte(byte2);
                        writerbin1.Write(n);
                    }
                   

                }
            }

        }

        private void textBox_lsfr1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar("1")) | e.KeyChar == '\b' | (e.KeyChar == Convert.ToChar("0"))) return;
            else
                e.Handled = true;
        }

        private void textBox_lsfr2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar("1")) | e.KeyChar == '\b' | (e.KeyChar == Convert.ToChar("0"))) return;
            else
                e.Handled = true;
        }

        private void textBox_lsfr3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == Convert.ToChar("1")) | e.KeyChar == '\b' | (e.KeyChar == Convert.ToChar("0"))) return;
            else
                e.Handled = true;
        }
    }
}
