using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;



namespace scanfile
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog1.FileName;
                try
                {
                    //Prints file
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    MessageBox.Show(text);

                    //Prints in LowerCase
                    string lower = text.ToLower();
                    MessageBox.Show(lower);

                    

                    string inFile = text;
                    string outFile = text;
                    var contents = File.ReadAllLines(inFile);
                    Array.Sort(contents);
                    File.WriteAllLines(outFile, contents);

                    MessageBox.Show(text);



                    











                }
                catch (IOException)
                {
                }
            }
            

            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);



                    //Prints in LowerCase
                    string lower = text.ToLower();
                    
                    textBox1.AppendText(lower);

                    string[] alpha = File.ReadAllLines(file);
                    Array.Sort(alpha);
                    textBox2.Text = alpha[0];
                    textBox6.Text = alpha[5];

                    







                }
                catch (IOException)
                {
                }
            }
            
            


            





        }

        

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button3_Click(object sender, EventArgs e)
        {
            
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string[] text = File.ReadAllLines(file);


                    string longest = text.OrderByDescending(s => s.Length).First();
                    textBox3.Text = longest;

                    

                    

                }
                catch (IOException)
                {
                }
            }
         


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string[] text = File.ReadAllLines(file);
                    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
                    char[] sk = { ' ', '.', ',', '!', '?', ':', ';', '(', ')', '\t' };
                    string word = "";
                    var mostVowels = 0;
                    for (int i = 0; i < text.Length; i++)
                    {
                        var part = text[i];
                        var numberOfVowels = 0;
                        foreach (var vowel in vowels)
                        {
                            if (part.Contains(vowel)) numberOfVowels++;
                        }

                        if (mostVowels < numberOfVowels)
                        {
                            mostVowels = i;
                            word = part;
                        }
                    }
                    textBox5.Text = word;








                }
                catch (IOException)
                {
                }
            }
          

            
        }
    }
}              
            

         







        
    
