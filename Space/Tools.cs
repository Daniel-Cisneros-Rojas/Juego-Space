using System;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics;
using System.IO;
using OpenTK.Graphics.OpenGL;


namespace Space
{
	
	public class Tools
	{
		//Graficos dibujo=new Graficos();
		public Tools()
		{
			
		}
		
		public void leerarchivo(string doc)
		{
		int auxx=0;
		int auxy=0;
		int numero;
		
		String line;
		StreamReader sr = new StreamReader(doc);
		while(!sr.EndOfStream)
		{
		  auxx=0;
		  line = sr.ReadLine();
		  string[]valor=line.Split(',');
		  for(int i=0;i<valor.Length;i++)
		  {
		    Int32.TryParse(valor[i], out numero);
		  	Console.Write(valor[i]+"");
	        
		  	auxx++;
		  }
		  auxy++;
       	  Console.WriteLine();
       	  
       	 
       	  
		}
		
		
		 Console.WriteLine("x"+auxx+"y"+auxy);
		}
		
		
	    
		public void disparar(Punto a,int activo,int tiempo)
		{
			
		}
	    
	    
	    
	    
	    
	    
	    
	    }
	}