using System;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics;
using System.IO;
using OpenTK.Graphics.OpenGL;


namespace Space
{
	public class Alien1
	{
		Graficos dibujo=new Graficos();
		Punto posicion;
		int modelo=0;
		int vivo=1;
		int colision=0;
		int muriendo=0;
		
		public Alien1()
		{
			posicion=new Punto(0,0);
		}
		public Alien1(Punto a)
		{
			posicion=new Punto(a.x,a.y);
		}
		
		public void mostrar()
		{
			if(colision==0)
			{
				if(modelo>=0&&modelo<30)
			 {
			   dibujo.dibujar(5,"alien1.txt",posicion);
			   
			 }
			if(modelo>=30)
			 {
				dibujo.dibujar(5,"alien1_2.txt",posicion);
			 	
			}
			if(modelo==60)
			{
				modelo=1;
			}
			
			modelo++;
			}
			else
			{
				morir();
			}
		}
		
		
		public Punto Ubicacion()
		{
			return posicion;
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
		
		public int activo()
		{
			return vivo;
		}
		public void morir()
		{
			muriendo++;
			dibujo.dibujar(5,"explosion.txt",posicion);
			if(muriendo>20)
			{
				vivo=0;
			}
			
		}
		public void buscar_colision(Nave nave)
		{
			if(nave.posicion_disparo_x()>=posicion.x&&nave.posicion_disparo_x()<=posicion.x+(12*5)&&nave.posicion_disparo_y()+3>=posicion.y&&nave.posicion_disparo_y()+3<=posicion.y+(8*5))
			{
				colision=1;
				//dibujo.dibujar(5,"explosion.txt",posicion);
				nave.acerto_disparo();
			}
			
		}
		
		public void reactivar()
		{
			vivo=1;
			colision=0;
		}
		
	}
}
