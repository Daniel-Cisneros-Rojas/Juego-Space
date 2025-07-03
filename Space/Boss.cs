using System;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics;
using System.IO;
using OpenTK.Graphics.OpenGL;


namespace Space
{
	
	public class Boss
	{
		
		
		Graficos dibujo=new Graficos();
		Punto posicion;
		int modelo=0;
		int vivo=1;
		int colision=0;
		int muriendo=0;
		int disparo_activo=1;
		int gatillo;
		int vidas=5;
		int velocidad_balas_jefe=10;
		Punto pos_disparo;
		Punto[] disparos=new Punto[5];
		int[] activos=new int[5];
		
		public Boss()
		{
			posicion=new Punto(0,0);
		}
		public Boss(Punto a)
		{
			posicion=new Punto(a.x,a.y);
			for(int i=0;i<5;i++)
			{
				activos[i]=1;
			}
		}
		
		public void mostrar()
		{
			if(colision==0)
			{
				if(modelo>=0&&modelo<30)
			 {
			   dibujo.dibujar(5,"alien4.txt",posicion);
			   
			 }
			if(modelo>=30)
			 {
				dibujo.dibujar(5,"alien4.txt",posicion);
			 	
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
			if(nave.posicion_disparo_x()>=posicion.x&&nave.posicion_disparo_x()<=posicion.x+(16*5)&&nave.posicion_disparo_y()+3>=posicion.y&&nave.posicion_disparo_y()+3<=posicion.y+(7*5))
			{
				vidas--;
				if(vidas<=0)
				{
					colision=1;
				}
				
				nave.acerto_disparo();
			}
			
		}

		
		public void mostrar_disparo(Nave nave)
		{
			for(int i=0;i<5;i++)
			{
				if(activos[i]==1)
			 {//25
					disparos[i]=new Punto(posicion.x+((i+1)*15),posicion.y+10);
			 }
				if(activos[i]==0)
			 {
					disparos[i].y=disparos[i].y-(velocidad_balas_jefe);
				dibujo.dibujar(5,"disparo_alien.txt",disparos[i]);
				if(disparos[i].y>0&&disparos[i].y<=(3*5)&&disparos[i].x>=nave.x&&disparos[i].x+(3*5)<=nave.x+(5*11))
				{
					activos[i]=1;
					nave.recibir_disparo();
				}
				
			 }
			if(disparos[i].y<0)
			{
				activos[i]=1;
			}
			velocidad_balas_jefe=velocidad_balas_jefe+5;
			if(velocidad_balas_jefe>=20)
			{
				velocidad_balas_jefe=10;
			}
			}
			
		}
		
		public void disparar()
		{
			for(int i=0;i<5;i++)
			{
				if(activos[i]==1)
			{
					activos[i]=0;
			}
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