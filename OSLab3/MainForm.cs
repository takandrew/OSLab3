using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OSLab3
{
    public partial class MainForm : Form
    {
        List<int> memoryList = new List<int>();
        List<int> pagesList = new List<int>();
        List<int> fifoList = new List<int>();
        List<int> lruList = new List<int>();
        int countOfInterruptions;
        public MainForm()
        {
            InitializeComponent();
            MaximizeBox = false;
        }

        private void GetMemory()
        {
            try
            {
                string dataString = MemoryTextBox.Text;
                string[] splittedDataString = dataString.Split(' ');
                int zero = 0;
                int countSpaces = zero;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        countSpaces++;
                    }
                }
                if (countSpaces == zero)
                {
                    MessageBox.Show("Исходные данные отсутствуют", "Внимание!");
                    return;
                }
                string[] withoutSpacesDataString = new string[countSpaces];
                int j = 0;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        withoutSpacesDataString[j] = splittedDataString[i];
                        j++;
                    }
                }
                for (int i = 0; i < withoutSpacesDataString.Length; i++)
                {
                    memoryList.Add(Convert.ToInt32(withoutSpacesDataString[i]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void GetPages()
        {
            try
            {
                string dataString = PagesTextBox.Text;
                string[] splittedDataString = dataString.Split(' ');
                int zero = 0;
                int countSpaces = zero;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        countSpaces++;
                    }
                }
                if (countSpaces == zero)
                {
                    MessageBox.Show("Исходные данные отсутствуют", "Внимание!");
                    return;
                }
                string[] withoutSpacesDataString = new string[countSpaces];
                int j = 0;
                for (int i = 0; i < splittedDataString.Length; i++)
                {
                    if (splittedDataString[i] != "")
                    {
                        withoutSpacesDataString[j] = splittedDataString[i];
                        j++;
                    }
                }
                for (int i = 0; i < withoutSpacesDataString.Length; i++)
                {
                    pagesList.Add(Convert.ToInt32(withoutSpacesDataString[i]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
        }

        private void FIFO()
        {
            for (int m = 0; m < memoryList.Count; m++)
                fifoList.Add(memoryList[m]);
            countOfInterruptions = 0;
            for (int k = 0; k < pagesList.Count; k++) 
            {
                string interruptionTag = "";
                if (!fifoList.Contains(pagesList[k])) 
                {
                    countOfInterruptions++;
                    if (fifoList[fifoList.Count - 1] != -1)
                    {
                        for (int i = 0; i < fifoList.Count - 1; i++)
                        {
                            fifoList[i] = fifoList[i + 1];
                        }
                        fifoList[fifoList.Count - 1] = pagesList[k];
                    }
                    else
                    {
                        fifoList[fifoList.Count - 1] = pagesList[k]; 
                    }
                    interruptionTag = " [Прерывание]";
                }
                if (k >= 9)
                    FIFOTextBox.Text += "Обращение№ " + (k + 1) + " Страница: " + pagesList[k]
                    + " Память: " + string.Join(",", fifoList) + interruptionTag + "\n";
                else
                    FIFOTextBox.Text += "Обращение№ " + (k + 1) + "   Страница: " + pagesList[k]
                    + " Память: " + string.Join(",", fifoList) + interruptionTag + "\n";
            }
            FIFOTextBox.Text += " Число прерываний: " + countOfInterruptions;
        }

        private void LRU()
        {
            countOfInterruptions = 0;
            for (int m = 0; m < memoryList.Count; m++)
                lruList.Add(memoryList[m]);
            for (int k = 0; k < pagesList.Count; k++)
            {
                string interruptionTag = "     ";

                if (!lruList.Contains(pagesList[k])) 
                {
                    countOfInterruptions++; 
                    if (lruList[lruList.Count - 1] != -1) 
                    {
                        for (int i = 0; i < lruList.Count - 1; i++)
                        {
                            lruList[i] = lruList[i + 1]; 
                        }
                        lruList[lruList.Count - 1] = pagesList[k]; 

                    }
                    else
                        lruList[lruList.Count - 1] = pagesList[k]; 
                    interruptionTag = " [Прерывание]"; 
                }
                else 
                {
                    int n;
                    if (lruList.Contains(-1))
                        n = 2; 
                    else 
                        n = 1; 
                    int temp = lruList.IndexOf(pagesList[k]);
                    int swaping = lruList[temp];
                    for (int i = temp; i < lruList.Count - n; i++) 
                    {
                        lruList[i] = lruList[i + 1];
                    }
                    lruList[lruList.Count - n] = swaping;
                }
                if (k >= 9)
                    LRUTextBox.Text += "Обращение№ " + (k + 1) + " Страница: " + pagesList[k]
                    + " Память: " + string.Join(",", lruList) + interruptionTag + "\n";
                else
                    LRUTextBox.Text += "Обращение№ " + (k + 1) + "   Страница: " + pagesList[k]
                    + " Память: " + string.Join(",", lruList) + interruptionTag + "\n";
            }
            LRUTextBox.Text += " Число прерываний: " + countOfInterruptions;
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            memoryList.Clear();
            pagesList.Clear();
            fifoList.Clear();
            lruList.Clear();
            FIFOTextBox.Clear();
            LRUTextBox.Clear();
            GetMemory();
            GetPages();
            FIFO();
            LRU();
        }
    }
}
