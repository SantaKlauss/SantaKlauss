using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Traffic
{
    
    public partial class cRenderForm : Form
    {
        public Random rand;          
        public float pAddCarInterval, pLightTime;
        public cRoad Road;
       	public Graphics g_buffer, g_form;
	    public Bitmap buffer;

        public cRenderForm()
        {
            InitializeComponent();
        }

        private void cRenderForm_Shown(object sender, EventArgs e)
        {
            rand = new Random();
            g_form = this.CreateGraphics();
            buffer = new Bitmap(600, 600);
            g_buffer = Graphics.FromImage(buffer);

            Road = new cRoad();
            Road.Lights = new cTrafficLight[6];
            Road.Lights[0] = new cTrafficLight(Color.Red, 5,2);
            Road.Lights[1] = new cTrafficLight(Color.Red, 5,2);
            Road.Lights[2] = new cTrafficLight(Color.Green, 5,2);
            Road.Lights[3] = new cTrafficLight(Color.Green, 5,2);
            
            Road.Lights[4] = new cTrafficLight(Color.Red, 7,3);
            Road.Lights[5] = new cTrafficLight(Color.Green, 7,3);
            

            Road.Cars = new ArrayList();
            cCar c = new cCar(0);
            
            c.rect.X = cRoad.RenderSize / 2 + cRoad.CrossDisp;
            c.speed.X = 0;
            c.drive = false;
            Road.Cars.Add(c);


            Road.AddCarInterval = pAddCarInterval;
            
            for (int i = 0; i < 4; i++)
            {
                Road.Lights[i].LightTime = pLightTime;
            }
            
            this.RenderTimer.Enabled = true;
            this.Timer.Enabled = true;
        }

        private void RenderTimer_Tick(object sender, EventArgs e)
        {
            Road.Update();
            g_buffer.Clear(Color.White);
            Road.Draw(g_buffer);
            g_form.DrawImage(buffer, new Point(0,0));
        }

        private void cRenderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.RenderTimer.Enabled = false;
            this.Timer.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.Text = "Количество автомобилей: "+Road.Cars.Count.ToString();
            for (int i = 0; i < 6; i++) Road.Lights[i].Update(Timer.Interval);
            Road.Second += (float)(Timer.Interval)/1000;
            if (Road.Second > Road.AddCarInterval)
            {
                int p = rand.Next(4) + 1;
                cCar newCar = new cCar(p);
                foreach (cCar Car in Road.Cars)                
                    if (CollChecker.RectInRect(newCar.rect,Car.rect)) return;
                
                Road.Cars.Add(newCar);
                Road.Second = 0;
            }
        }

    }

    enum cDriveState {sStop = 0, sDrive = 1};

    class CollChecker
    {
      static public bool PointInRect(Point p, Rectangle r)
      {
        if ((p.X >= r.X) && (p.X <= r.X + r.Width) && (p.Y >= r.Y) && (p.Y <= r.Y + r.Height))
            return true;
                else return false;
        }

      static public bool RectInRect(Rectangle r1, Rectangle r2)
      {
          if ((r1.X+r1.Width>r2.X) && (r1.X<r2.X+r2.Width) && (r1.Y+r1.Height>r2.Y) && (r1.Y<r2.Y+r2.Height))  return true;
          else return false;

      }
    }



    public class cRoad
    {
        public const int RenderSize = 600, RoadWidth = 40, CarWidth = 35, CarHeight = 15, CrossDisp = -150,
            RepairSince = 400, RepairWidht = 100, distance = 15, LightSize = 30;
        public float Second, AddCarInterval;

        public cTrafficLight[] Lights;
        public System.Collections.ArrayList Cars;

        public void Update()
        {
            for (int i = 0; i < Cars.Count; i++)
            {
                cCar c = (cCar)Cars[i];
                c.Update(this);
            }
        }

        public void Draw(Graphics G)
        {
            Pen pen = new Pen(Color.Black);

            G.DrawLine(pen, new Point(RenderSize / 2 - RoadWidth / 2 + CrossDisp, 0), new Point(RenderSize / 2 - RoadWidth / 2 + CrossDisp, RenderSize / 2 - RoadWidth / 2));
            G.DrawLine(pen, new Point(RenderSize / 2 + RoadWidth / 2 + CrossDisp, 0), new Point(RenderSize / 2 + RoadWidth / 2 + CrossDisp, RenderSize / 2 - RoadWidth / 2));

            G.DrawLine(pen, new Point(RenderSize / 2 - RoadWidth / 2 + CrossDisp, RenderSize), new Point(RenderSize / 2 - RoadWidth / 2 + CrossDisp, RenderSize / 2 + RoadWidth / 2));
            G.DrawLine(pen, new Point(RenderSize / 2 + RoadWidth / 2 + CrossDisp, RenderSize), new Point(RenderSize / 2 + RoadWidth / 2 + CrossDisp, RenderSize / 2 + RoadWidth / 2));

            G.DrawLine(pen, new Point(0, RenderSize / 2 - RoadWidth / 2), new Point(RenderSize / 2 - RoadWidth / 2 + CrossDisp, RenderSize / 2 - RoadWidth / 2));
            G.DrawLine(pen, new Point(0, RenderSize / 2 + RoadWidth / 2), new Point(RenderSize / 2 - RoadWidth / 2 + CrossDisp, RenderSize / 2 + RoadWidth / 2));

            G.DrawLine(pen, new Point(RenderSize / 2 + RoadWidth / 2 + CrossDisp, RenderSize / 2 - RoadWidth / 2), new Point(RenderSize, RenderSize / 2 - RoadWidth / 2));
            G.DrawLine(pen, new Point(RenderSize / 2 + RoadWidth / 2 + CrossDisp, RenderSize / 2 + RoadWidth / 2), new Point(RenderSize, RenderSize / 2 + RoadWidth / 2));

            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            pen.DashOffset = 50;
            pen.DashPattern = new float[] { 20.0F, 20.0F };

            G.DrawLine(pen, new Point(0, RenderSize / 2), new Point(RenderSize, RenderSize / 2));
            G.DrawLine(pen, new Point(RenderSize / 2 + CrossDisp, 0), new Point(RenderSize / 2 + CrossDisp, RenderSize));

            G.FillRectangle(new SolidBrush(Color.Chocolate), new Rectangle(RepairSince, RenderSize / 2 - RoadWidth / 2, RepairWidht, RoadWidth / 2));

            Lights[0].DrawLight(G, (int)(RenderSize / 2 - RoadWidth / 2 - LightSize / 1.6 + CrossDisp), (int)(RenderSize / 2 + RoadWidth / 2 + LightSize / 1.6), LightSize);
            Lights[1].DrawLight(G, (int)(RenderSize / 2 + RoadWidth / 2 + LightSize / 1.6 + CrossDisp), (int)(RenderSize / 2 - RoadWidth / 2 - LightSize / 1.6), LightSize);
            Lights[2].DrawLight(G, (int)(RenderSize / 2 - RoadWidth / 2 - LightSize / 1.6 + CrossDisp), (int)(RenderSize / 2 - RoadWidth / 2 - LightSize / 1.6), LightSize);
            Lights[3].DrawLight(G, (int)(RenderSize / 2 + RoadWidth / 2 + LightSize / 1.6 + CrossDisp), (int)(RenderSize / 2 + RoadWidth / 2 + LightSize / 1.6), LightSize);

            Lights[4].DrawLight(G, (int)(RepairSince - LightSize / 2 - cRoad.CarWidth - cRoad.distance), (int)(RenderSize / 2 + RoadWidth / 2 + LightSize / 1.6), LightSize);
            Lights[5].DrawLight(G, (int)(RepairSince + RepairWidht + LightSize / 2), (int)(RenderSize / 2 - RoadWidth / 2 - LightSize / 1.6), LightSize);


            foreach (cCar c in Cars) c.Draw(G);
        }

        public bool isOtherCarInArea(cCar car, Rectangle SearchRect, bool OtherLight)
        {           
            foreach (cCar c in Cars) if (car != c)
                    if (CollChecker.RectInRect(c.rect, SearchRect))
                    {
                        if (OtherLight) if (car.LightID == c.LightID) continue;
                        return true;
                    }
            return false;
        }
    }
    public class cTrafficLight
    {
        public Color CurrentColor;
        public float Second, LightTime, YellowTime;

        public cTrafficLight(Color C, float LT, float YT)
        {
            CurrentColor = C;
            LightTime = LT;
            Second = 0;
            YellowTime = YT;
        }

        public void Update(float dTime)
        {
            Second += dTime/1000;
            if (Second > LightTime)
            {
                if (CurrentColor == Color.Red) CurrentColor = Color.Green;
                else CurrentColor = Color.Red;               
                Second = 0;
            }
        }

        public void DrawLight(Graphics G, int cx, int cy, int size)
        {
            Rectangle R = new Rectangle();
            R.Height = size;            
            R.Width = size;
            R.X = cx-size/2;
            R.Y = cy-size/2;
            G.DrawRectangle(new Pen(Color.Black), R);
            Color c = CurrentColor;
            if ((CurrentColor == Color.Green) && (LightTime - Second < YellowTime)) c = Color.Yellow; 
            G.FillEllipse(new SolidBrush(c), R);
        }

    }
    


    public class cCar
    {
        public Rectangle rect;
        public bool drive;
        public int LightID;
        public Point speed;

        public cCar(int r)
        {
            switch (r)
            {
                case 1:
                    rect = new Rectangle(-cRoad.CarWidth,cRoad.RenderSize / 2 + 2,cRoad.CarWidth,cRoad.CarHeight);                                      
                    speed.X = 2;
                    LightID = 0;
                    break;
                case 2:
                    rect = new Rectangle(cRoad.RenderSize + cRoad.CarWidth, cRoad.RenderSize / 2 - cRoad.RoadWidth / 2 + 2, cRoad.CarWidth, cRoad.CarHeight);
                    speed.X = -2;
                    LightID = 5;
                    break;
                case 3:
                    rect = new Rectangle(cRoad.RenderSize / 2 - cRoad.RoadWidth / 2 + 2 + cRoad.CrossDisp, -cRoad.CarWidth * 2, cRoad.CarHeight, cRoad.CarWidth);                 
                    speed.Y = 2;                        
                    LightID = 2;
                    break;
                case 4:
                    rect = new Rectangle(cRoad.RenderSize / 2 + 2 + cRoad.CrossDisp, cRoad.RenderSize, cRoad.CarHeight, cRoad.CarWidth);                 
                    speed.Y = -2;
                    LightID = 3;
                    break;
                }
        }
        public Rectangle GetDistanceRect(int distance)
        {
            Rectangle r = rect;
            if (speed.X > 0) r.Width += distance;
            if (speed.X < 0) r.X -= distance;

            if (speed.Y > 0) r.Height += distance;
            if (speed.Y < 0) r.Y -= distance;
            return r;
        }

        public Point GetPointtAhead(int distance)
        {
            Point p = new Point(0,0);
            if (speed.X > 0) p = new Point(rect.X + rect.Width + distance, rect.Y + cRoad.CarHeight / 2);
            if (speed.X < 0) p = new Point(rect.X - distance, rect.Y + cRoad.CarHeight / 2);

            if (speed.Y > 0) p = new Point(rect.X + rect.Width / 2, rect.Y + rect.Height + distance);
            if (speed.Y < 0) p = new Point(rect.X + rect.Width / 2, rect.Y - distance);
            
            return p;
        }

        public void Update(cRoad r)
        {
            if (!((speed.X == 0) && (speed.Y==0))) 
                drive = true;
            Rectangle CrossRect = new Rectangle(cRoad.RenderSize / 2 - cRoad.RoadWidth / 2 + cRoad.CrossDisp, cRoad.RenderSize / 2 - cRoad.RoadWidth / 2,
                    cRoad.RoadWidth, cRoad.RoadWidth);
            foreach (cCar c in r.Cars)
                if (c != this)
                    if (CollChecker.RectInRect(GetDistanceRect(cRoad.distance), c.rect)) drive = false;
                    
      
            Rectangle LightArea;
            if (LightID < 4)
                LightArea = new Rectangle(cRoad.RenderSize / 2 - cRoad.RoadWidth / 2 + cRoad.CrossDisp, cRoad.RenderSize / 2 - cRoad.RoadWidth / 2,
                    cRoad.RoadWidth, cRoad.RoadWidth);
            else
            if (LightID == 4)
                LightArea = new Rectangle(cRoad.RepairSince-cRoad.CarWidth-cRoad.distance-5, cRoad.RenderSize / 2 - cRoad.RoadWidth / 2, cRoad.RepairWidht, cRoad.RoadWidth);
            else
                LightArea = new Rectangle(cRoad.RepairSince, cRoad.RenderSize / 2 - cRoad.RoadWidth / 2, cRoad.RepairWidht, cRoad.RoadWidth);

                

            if ((r.Lights[LightID].CurrentColor == Color.Red) || (((r.Lights[LightID].CurrentColor == Color.Green) && (r.Lights[LightID].LightTime - r.Lights[LightID].Second < r.Lights[LightID].YellowTime))))
                if (!CollChecker.RectInRect(GetDistanceRect(0), LightArea))
                   if (CollChecker.RectInRect(GetDistanceRect(cRoad.distance), LightArea)) drive = false;


            if (LightID == 5) 
            {
                if (CollChecker.RectInRect(rect, LightArea))
                {
                    Rectangle rec = rect;
                    rec.Y = cRoad.RenderSize / 2 + 2;
                    if (!r.isOtherCarInArea(this, rec, false))
                        rect.Y = cRoad.RenderSize / 2 + 2;
                    else drive = false;
                    
                }
                    if (rect.X + rect.Width < cRoad.RepairSince)
                {
                    Rectangle rec = rect;
                    rec.Y = cRoad.RenderSize / 2 - cRoad.RoadWidth / 2 + 2;
                    if (!r.isOtherCarInArea(this, rec, false))
                    {
                        LightID = 1;
                        rect.Y = cRoad.RenderSize / 2 - cRoad.RoadWidth / 2 + 2;
                    }
                    else drive = false;
                }
            }
                if ((LightID == 0) && (rect.X > cRoad.RenderSize/2+cRoad.RoadWidth/2+cRoad.CrossDisp)) LightID = 4;


            if ((speed.X > 0) && (rect.X > cRoad.RenderSize)) r.Cars.Remove(this);
            if ((speed.X < 0) && (rect.X+rect.Width < 0)) r.Cars.Remove(this);

            if ((speed.Y > 0) && (rect.Y > cRoad.RenderSize)) r.Cars.Remove(this);
            if ((speed.Y < 0) && (rect.Y + rect.Height < 0)) r.Cars.Remove(this);


            if (!drive) return;

            rect.X += speed.X;
            rect.Y += speed.Y;

        }

        public void Draw(Graphics G)
        {
            G.FillRectangle(new SolidBrush(Color.Blue), rect);  

        }
    }
}


