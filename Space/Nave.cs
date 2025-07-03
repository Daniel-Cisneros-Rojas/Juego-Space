using System;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics;
using System.IO;
using OpenTK.Graphics.OpenGL;


namespace Space
{
	
	public class Nave
	{
		int vidas=3;
		int disparo_activo=1;
		Graficos dibujo=new Graficos();
		Punto posicion= new Punto(400,10);
		Punto pos_disparo;
		public Nave()
		{
		}
		
		public void derecha()
		{
			if(posicion.x<810)
			{
				posicion.x=posicion.x+10;
			}
			
		}
		public void izquierda()
		{
			if(posicion.x>10)
			{
				posicion.x=posicion.x-10;
			}
		}
		
		public void mostrar()
		{
			dibujo.dibujar(5,"nave.txt",posicion);
			
		}
		
		public void mostrar_disparo()
		{
			if(disparo_activo==1)
			{
				pos_disparo=new Punto(posicion.x+25,posicion.y+10);
			}
			if(disparo_activo==0)
			{
				pos_disparo.y=pos_disparo.y+10;
				dibujo.dibujar(5,"disparo.txt",pos_disparo);
			}
			if(pos_disparo.y>800)
			{
				disparo_activo=1;
			}
		}
		
		public void disparar()
		{
			if(disparo_activo==1)
			{
				disparo_activo=0;
			}
			
		}
		
		
		public int posicion_disparo_x()
		{
			return (int)pos_disparo.x;
		}
		
		public int posicion_disparo_y()
		{
			return (int)pos_disparo.y;
		}
		
		public void mostrar_vidas()
		{
			for(int i=0;i<vidas;i++)
			{
				dibujo.dibujar(3,"nave.txt",new Punto(800-(i*37),860));
			}
			
		}
		
		public int recibir_disparo()
		{
			vidas--;
			return vidas;
		}
		
		public int vidas_restantes()
		{
			return vidas;
		}
		
		public void acerto_disparo()
		{
			disparo_activo=1;
		}
		
		public int x
		{
			get{return (int)posicion.x;}
			set{posicion.x=value;}
		}
		
		public int y
		{
			get{return (int)posicion.y;}
			set{posicion.y=value;}
		}
		
	}
}
