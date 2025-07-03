using System;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics;
using System.IO;
using OpenTK.Graphics.OpenGL;


namespace Space
{
	
	public class Alien3
	{
		
		
		Graficos dibujo=new Graficos();
		Punto posicion;
		int modelo=0;
		int vivo=1;
		int colision=0;
		int muriendo=0;
		int disparo_activo=1;
		int gatillo;
		Punto pos_disparo;
		
		public Alien3()
		{
			posicion=new Punto(0,0);
		}
		public Alien3(Punto a)
		{
			posicion=new Punto(a.x,a.y);
		}
		
		public void mostrar()
		{
			if(colision==0)
			{
				if(modelo>=0&&modelo<30)
			 {
			   dibujo.dibujar(5,"alien3.txt",posicion);
			   
			 }
			if(modelo>=30)
			 {
				dibujo.dibujar(5,"alien3_2.txt",posicion);
			 	
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
			if(nave.posicion_disparo_x()>=posicion.x&&nave.posicion_disparo_x()<=posicion.x+(8*5)&&nave.posicion_disparo_y()+3>=posicion.y&&nave.posicion_disparo_y()+3<=posicion.y+(8*5))
			{
				colision=1;
				nave.acerto_disparo();
			}
			
		}

		
		public void mostrar_disparo(Nave nave)
		{
			if(disparo_activo==1)
			{
				pos_disparo=new Punto(posicion.x+25,posicion.y+10);
			}
			if(disparo_activo==0)
			{
				pos_disparo.y=pos_disparo.y-15;
				dibujo.dibujar(5,"disparo_alien.txt",pos_disparo);
				if(pos_disparo.y>0&&pos_disparo.y<=(3*5)&&pos_disparo.x>=nave.x&&pos_disparo.x+(3*5)<=nave.x+(5*11))
				{
					disparo_activo=1;
					nave.recibir_disparo();
				}
				
			}
			if(pos_disparo.y<0)
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
		public void reactivar()
		{
			vivo=1;
			colision=0;
		}
		
		
		
	}
}