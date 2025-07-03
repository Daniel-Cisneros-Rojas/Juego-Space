using System;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics;
using System.IO;
using OpenTK.Graphics.OpenGL;


namespace Space
{
	/// <summary>
	/// Description of Graficos.
	/// </summary>
	public class Graficos
	{
		
		public Graficos()
		{
		}
		
		
		
		public void numeros(Punto a,int num)
		{
			switch(num)
			{
            case 0:
            GL.LineWidth(3);
            GL.Begin(PrimitiveType.LineLoop);
            GL.Color3(Color.White);
            GL.Vertex2(a.x,a.y);
            GL.Vertex2(a.x+20,a.y);
            GL.Vertex2(a.x+20,a.y+30);
            GL.Vertex2(a.x,a.y+30);
            GL.End();
             break;
            case 1:
             GL.LineWidth(3);
             GL.Begin(PrimitiveType.LineLoop);
             GL.Color3(Color.White);
             GL.Vertex2(a.x+10,a.y);
             GL.Vertex2(a.x+10,a.y+30);
             GL.End();
             break;
            case 2:
             GL.LineWidth(3);
             GL.Begin(PrimitiveType.LineStrip);
             GL.Color3(Color.White);
             GL.Vertex2(a.x+20,a.y);
             GL.Vertex2(a.x,a.y);
             GL.Vertex2(a.x,a.y+15);
             GL.Vertex2(a.x+20,a.y+15);
             GL.Vertex2(a.x+20,a.y+30);
             GL.Vertex2(a.x,a.y+30);
             
             GL.End();
             break;
            case 3:
             GL.LineWidth(3);
             GL.Begin(PrimitiveType.LineStrip);
             GL.Color3(Color.White);
             GL.Vertex2(a.x,a.y);
             GL.Vertex2(a.x+20,a.y);
             GL.Vertex2(a.x+20,a.y+15);
             GL.Vertex2(a.x,a.y+15);
             GL.Vertex2(a.x+20,a.y+15);
             GL.Vertex2(a.x+20,a.y+30);
             GL.Vertex2(a.x,a.y+30);
             
             GL.End();
             break;
             
            case 4:
             GL.LineWidth(3);
             GL.Begin(PrimitiveType.LineStrip);
             GL.Color3(Color.White);
             GL.Vertex2(a.x+20,a.y);
             GL.Vertex2(a.x+20,a.y+30);
             GL.Vertex2(a.x+20,a.y+15);
             GL.Vertex2(a.x,a.y+15);
             GL.Vertex2(a.x,a.y+30);
             
             GL.End();
             break;
             
             case 5:
             GL.LineWidth(3);
             GL.Begin(PrimitiveType.LineStrip);
             GL.Color3(Color.White);
             GL.Vertex2(a.x,a.y);
             GL.Vertex2(a.x+20,a.y);
             GL.Vertex2(a.x+20,a.y+15);
             GL.Vertex2(a.x,a.y+15);
             GL.Vertex2(a.x,a.y+30);
             GL.Vertex2(a.x+20,a.y+30);
            
             
             GL.End();
             break;
             
             case 6:
             GL.LineWidth(3);
             GL.Begin(PrimitiveType.LineStrip);
             GL.Color3(Color.White);
             GL.Vertex2(a.x+20,a.y+30);
             GL.Vertex2(a.x,a.y+30);
             GL.Vertex2(a.x,a.y);
             GL.Vertex2(a.x+20,a.y);
             GL.Vertex2(a.x+20,a.y+15);
             GL.Vertex2(a.x,a.y+15);
            
             GL.End();
             break;
             
             
             case 7:
             GL.LineWidth(3);
             GL.Begin(PrimitiveType.LineStrip);
             GL.Color3(Color.White);
             GL.Vertex2(a.x+20,a.y);
             GL.Vertex2(a.x+20,a.y+15);
             GL.Vertex2(a.x+10,a.y+15);
             GL.Vertex2(a.x+20,a.y+15);
             GL.Vertex2(a.x+20,a.y+30);
             GL.Vertex2(a.x,a.y+30);
             
            
             GL.End();
             break;
             
             case 8:
             GL.LineWidth(3);
             GL.Begin(PrimitiveType.LineStrip);
             GL.Color3(Color.White);
             GL.Vertex2(a.x,a.y);
             GL.Vertex2(a.x+20,a.y);
             GL.Vertex2(a.x+20,a.y+15);
             GL.Vertex2(a.x,a.y+15);
             GL.Vertex2(a.x,a.y);
             GL.Vertex2(a.x,a.y+30);
             GL.Vertex2(a.x+20,a.y+30);
             GL.Vertex2(a.x+20,a.y+15);
             
             GL.End();
             break;
             
             
             case 9:
             GL.LineWidth(3);
             GL.Begin(PrimitiveType.LineStrip);
             GL.Color3(Color.White);
             GL.Vertex2(a.x+20,a.y);
             GL.Vertex2(a.x+20,a.y+30);
             GL.Vertex2(a.x,a.y+30);
             GL.Vertex2(a.x,a.y+15);
              GL.Vertex2(a.x+20,a.y+15);
             
             
             
             GL.End();
             break;
             
             default:
    
            break;
			}
}
		public void score(Punto a,int num)
		{
			int cifras,cont=0;
			while(num>0)
				{
					cifras=num%10;
					num=num/10;
					//Console.WriteLine(cifras[cont]);
					
					numeros(new Punto(a.x-(cont*30),a.y),cifras);
					cont++;
				}
		}
		
		public void palabra_score(Punto a)
		{
			GL.LineWidth(3);
            GL.Begin(PrimitiveType.LineStrip);
            GL.Color3(Color.White);
            GL.Vertex2(a.x+10,a.y);
            GL.Vertex2(a.x+30,a.y);
            GL.Vertex2(a.x+30,a.y+15);
            GL.Vertex2(a.x+10,a.y+15);
            GL.Vertex2(a.x+10,a.y+30);
            GL.Vertex2(a.x+30,a.y+30);
            GL.End();
            
            GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(a.x+55,a.y);
            GL.Vertex2(a.x+40,a.y);
            GL.Vertex2(a.x+40,a.y+30);
            GL.Vertex2(a.x+55,a.y+30);
            GL.End();
            
            GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(a.x+80,a.y);
            GL.Vertex2(a.x+60,a.y);
            GL.Vertex2(a.x+60,a.y+30);
            GL.Vertex2(a.x+80,a.y+30);
            GL.Vertex2(a.x+80,a.y);
            GL.End();
            
            GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(a.x+90,a.y);
            GL.Vertex2(a.x+90,a.y+30);
            GL.Vertex2(a.x+110,a.y+30);
            GL.Vertex2(a.x+110,a.y+15);
            GL.Vertex2(a.x+90,a.y+15);
            GL.Vertex2(a.x+110,a.y+15);
            GL.Vertex2(a.x+115,a.y);
            GL.End();
            
            GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(a.x+135,a.y);
            GL.Vertex2(a.x+120,a.y);
            GL.Vertex2(a.x+120,a.y+15);
            GL.Vertex2(a.x+135,a.y+15);
            GL.Vertex2(a.x+120,a.y+15);
            GL.Vertex2(a.x+120,a.y+30);
            GL.Vertex2(a.x+135,a.y+30);
            GL.End();
            
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex2(a.x+145,a.y+25);
            GL.Vertex2(a.x+145,a.y+20);
            GL.Vertex2(a.x+150,a.y+20);
            GL.Vertex2(a.x+150,a.y+25);
            GL.End();
            
            GL.Begin(PrimitiveType.Polygon);
            GL.Vertex2(a.x+145,a.y+10);
            GL.Vertex2(a.x+145,a.y+5);
            GL.Vertex2(a.x+150,a.y+5);
            GL.Vertex2(a.x+150,a.y+10);
            GL.End();
		}
		
		public void palabra_perdiste(Punto a)
		{
			GL.LineWidth(3);
            GL.Begin(PrimitiveType.LineStrip);
            GL.Color3(Color.White);
            GL.Vertex2(a.x+10,a.y);
            GL.Vertex2(a.x+10,a.y+30);
            GL.Vertex2(a.x+30,a.y+30);
            GL.Vertex2(a.x+30,a.y+15);
            GL.Vertex2(a.x+10,a.y+15);
            GL.End();
            
            GL.LineWidth(3);
            GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(a.x+60,a.y);
            GL.Vertex2(a.x+40,a.y);
            GL.Vertex2(a.x+40,a.y+15);
            GL.Vertex2(a.x+60,a.y+15);
            GL.Vertex2(a.x+40,a.y+15);
            GL.Vertex2(a.x+40,a.y+30);
            GL.Vertex2(a.x+60,a.y+30);
            GL.End();
            
            GL.LineWidth(3);
            GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(a.x+70,a.y);
            GL.Vertex2(a.x+70,a.y+30);
            GL.Vertex2(a.x+90,a.y+30);
            GL.Vertex2(a.x+90,a.y+15);
            GL.Vertex2(a.x+70,a.y+15);
            GL.Vertex2(a.x+90,a.y+15);
            GL.Vertex2(a.x+94,a.y);
            GL.End();
            
            GL.LineWidth(3);
            GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(a.x+100,a.y);
            GL.Vertex2(a.x+100,a.y+30);
            GL.Vertex2(a.x+110,a.y+30);
            GL.Vertex2(a.x+120,a.y+15);
            GL.Vertex2(a.x+110,a.y);
            GL.Vertex2(a.x+100,a.y);
            GL.End();
            
            GL.LineWidth(3);
            GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(a.x+130,a.y);
            GL.Vertex2(a.x+130,a.y+30);
            GL.End();
            
            GL.LineWidth(3);
            GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(a.x+140,a.y);
            GL.Vertex2(a.x+160,a.y);
            GL.Vertex2(a.x+160,a.y+15);
            GL.Vertex2(a.x+140,a.y+15);
            GL.Vertex2(a.x+140,a.y+30);
            GL.Vertex2(a.x+160,a.y+30);
            GL.End();
            
            GL.LineWidth(3);
            GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(a.x+180,a.y);
            GL.Vertex2(a.x+180,a.y+30);
            GL.Vertex2(a.x+170,a.y+30);
            GL.Vertex2(a.x+190,a.y+30);
            GL.End();
            
            GL.LineWidth(3);
            GL.Begin(PrimitiveType.LineStrip);
            GL.Vertex2(a.x+220,a.y);
            GL.Vertex2(a.x+200,a.y);
            GL.Vertex2(a.x+200,a.y+15);
            GL.Vertex2(a.x+220,a.y+15);
            GL.Vertex2(a.x+200,a.y+15);
            GL.Vertex2(a.x+200,a.y+30);
            GL.Vertex2(a.x+220,a.y+30);
            GL.End();
		}
		
		public void rectangulo(Punto a, Punto b)
		{
			GL.Begin(PrimitiveType.Polygon);
			//GL.Color3(Color.Black);
			GL.Vertex2(a.x,b.y);
			GL.Vertex2(a.x,a.y);
			GL.Vertex2(b.x,a.y);
			GL.Vertex2(b.x,b.y);
			GL.End();
		}
		
		public void dibujar(int tam,string archivo,Punto posicion)
		{
			//string text = System.IO.File.ReadAllText(@"D:\Documents\ejemplo.txt");
            //System.Console.WriteLine("Contenido del archivo = {0}", text);
        int auxx=0;
		int auxy=0;
		//tam7
		String line;
		StreamReader sr = new StreamReader(archivo);
		while(!sr.EndOfStream)
		{
		  auxx=0;
		  line = sr.ReadLine();
		  string[]valor=line.Split(',');
		  for(int i=0;i<valor.Length;i++)
		  {
		  	//string[]valor=line.Split(' ');
		  	//Console.Write(valor[i]+"");
		  	
		  	       if(valor[i]=="1")
					{
		  	       	    GL.Color3(1f, 1f, 1f);
						rectangulo(new Punto(posicion.x+(auxx*tam),posicion.y+tam+(auxy*tam)),new Punto(posicion.x+tam+(auxx*tam),posicion.y+(auxy*tam)));
					}
					if(valor[i]=="2")
					{
						GL.Color3(Color.Red);
						rectangulo(new Punto(posicion.x+(auxx*tam),posicion.y+tam+(auxy*tam)),new Punto(posicion.x+tam+(auxx*tam),posicion.y+(auxy*tam)));
					}
					if(valor[i]=="3")
					{
						GL.Color3(Color.LimeGreen);
						rectangulo(new Punto(posicion.x+(auxx*tam),posicion.y+tam+(auxy*tam)),new Punto(posicion.x+tam+(auxx*tam),posicion.y+(auxy*tam)));
					}
					if(valor[i]=="4")
					{
						GL.Color3(0f, 0f, 0.22f);
						rectangulo(new Punto(posicion.x+(auxx*tam),posicion.y+tam+(auxy*tam)),new Punto(posicion.x+tam+(auxx*tam),posicion.y+(auxy*tam)));
					}
					if(valor[i]=="5")
					{
						GL.Color3(0.07f, 0.05f, 0.27f);
						rectangulo(new Punto(posicion.x+(auxx*tam),posicion.y+tam+(auxy*tam)),new Punto(posicion.x+tam+(auxx*tam),posicion.y+(auxy*tam)));
					}
		  	
		  	
		  	
		  	auxx++;
		  }
		  auxy++;
       	  Console.WriteLine();
		}
		
		
		}
		
		
    
	}
}
