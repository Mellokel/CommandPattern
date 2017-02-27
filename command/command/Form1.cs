using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float radius;
        float widthX;
        float heightY;
        float x; float y;
        Point pNode;
        Image image1;
        Graphics g;
        Invoker Dots;

        Color currentColor;
        Color previousColor;
        int numberOfLustElement;
        int numberOfElement;


        int nNodes;

        private void DrawDots_Click(object sender, EventArgs e) 
        {
            Dots = new Invoker(this);
            nNodes = Convert.ToInt32(Count.Text);
            var command = new CreateCommand(this);
            Dots.PressButton(command);
        }

        public void getNodePos(int k) // определяем позицию для квадрата (расположены по кругу)
        {
            double ugol = (2 * Math.PI) / (nNodes + 1) * k;
            x = (float)(radius * Math.Cos(ugol) + widthX);
            y = (float)(radius * Math.Sin(ugol) + heightY);
           
        }
        
        public void Draw() // рисуем квадраты на picturebox
        {
            image1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            
            
            Pen pen = new Pen(Color.Red, 2);
            g = Graphics.FromImage(image1);
            widthX = pictureBox1.Width / 2;
            heightY = pictureBox1.Height / 2;
            radius = Math.Min(widthX, heightY) - 20;

            for (int i = 0; i <= nNodes; i++)
            {
                pNode = new Point();
                getNodePos(i);
                pNode.X = Convert.ToInt32(x);
                pNode.Y = Convert.ToInt32(y);
                g.DrawRectangle(pen, pNode.X + 5, pNode.Y + 5, 10, 10);

                g.FillRectangle(new SolidBrush(Color.Blue), pNode.X + 5, pNode.Y + 5, 10, 10);
                g.DrawString(i.ToString(), new Font("new Times Roman", 10), Brushes.Black, pNode.X + 10, pNode.Y + 5);
            }
            pictureBox1.Image = image1;
        }

        public void Clear() { // очистка при отмене последней команды
            pictureBox1.Image = null;
        }
        public void getNewParametrs() {
            if (Convert.ToBoolean(numberOfElement))
                numberOfLustElement = numberOfElement;
            numberOfElement = Convert.ToInt32(First.Text);

            getNodePos(numberOfElement);
            pNode.X = Convert.ToInt32(x);
            pNode.Y = Convert.ToInt32(y);

            previousColor = ((Bitmap)pictureBox1.Image).GetPixel(Convert.ToInt32(x) + 5, Convert.ToInt32(y) + 5);
            currentColor = Color.FromName(comboBox1.Text);
        }


        private void Execute_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                getNewParametrs();

                Dots.PressButton(new ChangeColorCommand(this, previousColor, numberOfElement));
            }
        }

        public void ChangeColor( )
        {
            g.FillRectangle(new SolidBrush(currentColor), pNode.X + 5, pNode.Y + 5, 10, 10);
            pictureBox1.Image = image1;
        }
        public void ReChangeColor(Color color, int number) // отмена последней перерисовки квадрата
        {
            currentColor = color;
            numberOfElement = number;

            getNodePos(numberOfElement);
            pNode.X = Convert.ToInt32(x);
            pNode.Y = Convert.ToInt32(y);

            g.FillRectangle(new SolidBrush(currentColor), pNode.X + 5, pNode.Y + 5, 10, 10);
            pictureBox1.Image = image1;
        }

        private void UnExecute_Click(object sender, EventArgs e)
        {
            Dots.PressUndoButton();
        }
    }

  

    interface ICommand
    {
        string Name { get; }
        void Execute();
        void Undo();
    }
    
    class CreateCommand : ICommand
    {
        Form1 a;

        public string Name {
            get { return "Create"; }
        }

        public CreateCommand(Form1 a)
        {
            this.a = a;

        }

        public void Execute()
        {
           a.Draw();
        }
        public void Undo()
        {
            a.Clear();
        }
    }

    class ChangeColorCommand : ICommand
    {
        Form1 a;
        Color color;
        int number;

        public string Name
        {
            get { return "Change color"; }
        }

        public ChangeColorCommand(Form1 a, Color color, int number) {
            this.a = a;
            this.color = color;
            this.number = number;
        }

        public void Execute()
        {
            a.ChangeColor();
        }

        public void Undo()
        {
            a.ReChangeColor(color, number);
        }
    }

    class Invoker
    {
        
        Stack<ICommand> commandsHistory;

        public Invoker(Form1 a)
        {
           commandsHistory = new Stack<ICommand>();
        }

        public void PressButton(ICommand command)
        {
            command.Execute();
            commandsHistory.Push(command);
        }
        public void PressUndoButton()
        {
            if (commandsHistory.Count > 0)
            {
                var undoCommand = commandsHistory.Pop();
                undoCommand.Undo();
               
            }
        }
    }
    
}
