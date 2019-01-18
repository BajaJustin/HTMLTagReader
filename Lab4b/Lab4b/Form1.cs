/*
 * Author: Justin Baja
 * Student Number: 000356032
 * File Date: Thursday November 22, 2018
 * Programs Purpose: This program handles the users html file and checks for balance in html tags
 * Statement of Authorship: I, Justin Baja, 000356032 certify that this material is my original work. 
 * No other person's work has been used without due acknowledgement.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Able to share code through out the project
/// </summary>
namespace Lab4b
{
    /// <summary>
    /// This class handles events for form use and checks the files html opening and closing tag for balance
    /// </summary>
    public partial class Form1 : Form
    {
        // The read files name
        private string fileName;

        /// <summary>
        /// Forms default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens a new file into the form
        /// </summary>
        /// <param name="sender">reference to the control/object that raised the event</param>
        /// <param name="e">contains the event data</param>
        private void openMenu_Click(object sender, EventArgs e)
        {
            htmlOpenFileDialog.Title = "Select HTML File";
            htmlOpenFileDialog.Filter = "HTML files (*.html,*.htm) |*.html;*.htm";

            if (htmlOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = htmlOpenFileDialog.FileName;
                statusLabel.Text = fileName;
            }
            else
                statusLabel.Text = "File not selected";
        }
        /// <summary>
        /// Closes the file while exit button is clicked
        /// </summary>
        /// <param name="sender">reference to the control/object that raised the event</param>
        /// <param name="e">contains the event data</param>
        private void closeMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Reads the users file and checks the file for correct tags
        /// </summary>
        /// <param name="sender">reference to the control/object that raised the event</param>
        /// <param name="e">contains the event data</param>
        private void checkTagsMenu_Click(object sender, EventArgs e)
        {
            // Reads the users file
            StreamReader reader = new StreamReader(fileName);

            // Stack of opening and closing html tags
            Stack<string> tagStack = new Stack<string>();

            // Clears the tags list
            tagsListBox.Items.Clear();

            // Tags that don't have a closing tag
            string[] selfClosingTags = { "<img>", "<br>", "<hr>" };

            // Line that is read from the user's file
            string htmlFile;

            // Continue until the end of file is reached
            bool isEnd = false;

            // Reads the html file and adds it to a string
            htmlFile = reader.ReadToEnd();

            // Run until you reach the end of the file
            while (!isEnd)                                                                                               
            {
                // Grabs the starting index of "<"
                int startPosition = htmlFile.IndexOf("<"); 
                
                // Run while able to find a opening "<"
                if (startPosition != -1)                                                                                
                {
                    // Find the index of the closing ">"
                    int endPosition = htmlFile.IndexOf(">", startPosition); 
                    
                    // A tag found within the file
                    string tag = htmlFile.Substring(startPosition, endPosition +1 - startPosition);                     

                    // If the tag contains a space remove it and continue
                    if (tag.Contains(" "))
                    {
                        int temp = tag.IndexOf(" ");
                        tag = htmlFile.Substring(startPosition, temp) + ">";
                    }

                    // If tag does not contain a closing ( '/' ) character
                    if (tag[1] != '/')
                    {
                        if (!(selfClosingTags.Contains(tag)))
                        {
                            tagStack.Push(tag);
                        }
                    }
                    else
                    {
                        // Comparing the tag to the tag in the stack
                        if (tag.Substring(2).ToLower() != tagStack.Pop().Substring(1).ToLower())
                        {
                            statusLabel.Text = "Incorrect closing tag " + tag;
                            break;
                        }
                    }
                    tagsListBox.Items.Add(tag);
                    htmlFile = htmlFile.Substring(endPosition);
                }
                else
                    isEnd = true;
            }

            // If stack is empty return balanced else return not
            if (tagStack.Count == 0)
                statusLabel.Text = "File is balanced";
            else
                statusLabel.Text = "File is not balanced";

            // Closes the file
            reader.Close();
        }
    }
}
