using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Opdracht3Versleutelen
{
    public partial class Form1 : Form
    {
        
        private void SetupListBoxCipherMode()
        {
            listBoxCipherMode.Items.Clear();
            Action < Object > addObjectToListBoxCipherMode= (Object toAddObject) =>
            {
                listBoxCipherMode.Items.Add(toAddObject);
            };
            Encrypter.RunCipherModesThoughLambda(addObjectToListBoxCipherMode);
            listBoxCipherMode.SelectedItem = Encrypter.GetInitialCipherMode();
        }
        private void SetupListBoxPaddingMode()
        {
            listBoxPaddingMode.Items.Clear();
            Action<Object> addObjectToListBoxPaddingMode = (Object toAddObject) =>
            {
                listBoxPaddingMode.Items.Add(toAddObject);
            };
            Encrypter.RunPaddingModesThoughLambda(addObjectToListBoxPaddingMode);
            listBoxPaddingMode.SelectedItem = Encrypter.GetInitialPaddingMode();
        }
        private void SetupInitialKey()
        {
            textBoxKey.Text = Encrypter.GetInitialKey();
        }

        public Form1()
        {
            InitializeComponent();
            SetupListBoxCipherMode();
            SetupListBoxPaddingMode();
            SetupInitialKey();
            label4.Text = "";
        }

        private Object GetListBoxMode(Object selectedItem, Action<Action<Object>> targetFunction)
        {
            if (selectedItem != null)
            {
                object instance = null;
                Action<Object> tryToMatchObjectAndSelectedItem = (Object testAgainstObject) =>
                {

                    if (selectedItem.ToString().Equals(testAgainstObject.ToString()))
                    {
                        instance = testAgainstObject;
                    }
                };
                targetFunction(tryToMatchObjectAndSelectedItem);
                if (instance != null)
                {
                    return instance;
                    
                }
            }
            throw new Exception("mode isn't found");
        }
        private Object GetListBoxCipherModeMode()
        {
            Action<Action<Object>> targetFunction = (Action<Object> tryToMatchStatement) =>
              {
                  Encrypter.RunCipherModesThoughLambda(tryToMatchStatement);
              };
            return GetListBoxMode(listBoxCipherMode.SelectedItem,targetFunction);
        }
        private Object GetListBoxPaddingModeMode()
        {
            Action<Action<Object>> targetFunction = (Action<Object> tryToMatchStatement) =>
            {
                Encrypter.RunPaddingModesThoughLambda(tryToMatchStatement);
            };
            return GetListBoxMode(listBoxPaddingMode.SelectedItem, targetFunction);
        }

        private void SetRichTextBoxEditedText(string text)
        {
            richTextBoxEdited.Text = text;
        }
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                object cipherMode = GetListBoxCipherModeMode();
                object paddingMode = GetListBoxPaddingModeMode();
                string encrypted = Encrypter.EncryptString(richTextBoxUnedited.Text, textBoxKey.Text, cipherMode, paddingMode);
                SetRichTextBoxEditedText(encrypted);
            }
            catch (Exception exception)
            {
                MessageBox.Show("exception trown with tekst: "+exception.Message);
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                object cipherMode = GetListBoxCipherModeMode();
                object paddingMode = GetListBoxPaddingModeMode();
                string decrypted = Encrypter.DecryptString(Encrypter.EncryptString(richTextBoxUnedited.Text, textBoxKey.Text, cipherMode, paddingMode),textBoxKey.Text,cipherMode,paddingMode);
                SetRichTextBoxEditedText(decrypted);
            }
            catch (Exception exception)
            {
                MessageBox.Show("exception trown with tekst: " + exception.Message);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
