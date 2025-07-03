using System;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
namespace Space
{
	
	public class Pantalla:GameWindow
	{
         
		
		Tools herramientas=new Tools();
		Graficos dibujo=new Graficos();
		Nave nave=new Nave();
		Random rnd = new Random();
		int min=0,max=80,perdiste=0,fase=1,nivel=1,activos=27;
		
		Alien1[] alienT1=new Alien1[9];
		Alien2[] alienT2=new Alien2[9];
		Alien3[] alienT3=new Alien3[9];
		Boss jefe=new Boss();
		
		int puntos=0,avanzex=80,avanzey=60,movido=0,lado_mov=1,debemovery;
		double tiempo=0,t_dis_ali=0;
		
		
		
		public Pantalla():base(800,600,GraphicsMode.Default,"Space invaders")
		{
			
		}
		
		protected override void OnLoad(EventArgs e)
		{
			GL.ClearColor(Color.Black);
			GL.MatrixMode(MatrixMode.Projection);
			GL.Ortho(0,900,0,900,-1,1);
			for(int i=0;i<9;i++)
			{
				alienT1[i]=new Alien1(new Punto(60+(avanzex*i),500));
				alienT2[i]=new Alien2(new Punto(60+(avanzex*i),560));
			    alienT3[i]=new Alien3(new Punto(65+(avanzex*i),620));
			}
			jefe=new Boss(new Punto(300,600));
		}
		
		protected override void OnUpdateFrame(FrameEventArgs e)
		{
			GL.Clear(ClearBufferMask.ColorBufferBit);
			tiempo=tiempo+0.02;
			t_dis_ali=t_dis_ali+0.02;
			
		}
		
		protected override void OnRenderFrame(FrameEventArgs e)
		{
			if(perdiste==0)
			{ 
				  dibujo.palabra_score(new Punto(5,850));
			      dibujo.score(new Punto(250,850),puntos);
			      dibujo.score(new Punto(500,850),(int)tiempo);
			      nave.mostrar();
			      nave.mostrar_vidas();
			      nave.mostrar_disparo();
				if(fase==1)
				{
			      
			        for(int i=0;i<9;i++)
			      {
				    //alien1
				      if(alienT1[i].activo()==1)
			          {
				        alienT1[i].buscar_colision(nave);
				        alienT1[i].mostrar();
				         if(alienT1[i].activo()==0)
			             {
			    	        puntos=puntos+20;
			              }
								
			              }
				     //alien2
			          if(alienT2[i].activo()==1)
			          {
				        alienT2[i].buscar_colision(nave);
				        alienT2[i].mostrar();
				         if(alienT2[i].activo()==0)
			              {
			    	        puntos=puntos+30;
			               }
								
			          }
			       //alien 3
			         if(alienT3[i].activo()==1)
			         {
				      alienT3[i].buscar_colision(nave);
				      alienT3[i].mostrar();
				      alienT3[i].mostrar_disparo(nave);
				       if((int)t_dis_ali==3)
				         {
					       if(rnd.Next(min, max + 1)==1)
					       {
					        	alienT3[i].disparar();
					       }
				         }
				if(alienT3[i].activo()==0)
			    {
			    	puntos=puntos+50;
			    }
								
			  }
				
				if((int)tiempo==2)
				{
				 
				  if(debemovery==1)
				  {
				  	alienT1[i].y=alienT1[i].y-40;
				  	alienT2[i].y=alienT2[i].y-40;
				  	alienT3[i].y=alienT3[i].y-40;
				  	
				  }
				 
				  alienT1[i].x=alienT1[i].x+(20*lado_mov);
				  alienT2[i].x=alienT2[i].x+(20*lado_mov);
				  alienT3[i].x=alienT3[i].x+(20*lado_mov);
				  movido=1;
				  
				}
				
			}
			if(movido==1)
			{
				tiempo=0;
				movido=0;
				debemovery=0;
			}
			
			if(alienT1[8].x>=840)
			{
				lado_mov=-1;
				debemovery=1;
			}
			else if(alienT1[0].x<=10)
			{
				lado_mov=1;
				debemovery=1;
			}
			else{
				debemovery=0;
			}
			
			 if(t_dis_ali>4)
			 {
				t_dis_ali=0;
			 }
			}
				//                     fase 2
				if(fase==2)
				{
					max=20;
					 if(jefe.activo()==1)
			         {
				      jefe.buscar_colision(nave);
				      jefe.mostrar();
				      jefe.mostrar_disparo(nave);
				       if((int)t_dis_ali==1)
				         {
					       if(rnd.Next(min, max + 1)==1)
					       {
					        	jefe.disparar();
					       }
				         }
				           if(jefe.activo()==0)
			             {
			    	      puntos=puntos+300;
			             }
						if(t_dis_ali>4)
			             {
				             t_dis_ali=0;
			             } 

                         
                         if(tiempo>0.2)
				        {
				           jefe.x=jefe.x+(25*lado_mov);
				  
				           movido=1;
				  
				        }
                         
                         if(movido==1)
			{
				tiempo=0;
				movido=0;
				debemovery=0;
			}
			
			if(jefe.x>=820)
			{
				lado_mov=-1;
				debemovery=1;
			}
			else if(jefe.x<=10)
			{
				lado_mov=1;
				debemovery=1;
			}
			else{
				debemovery=0;
			}
                         
			          }
				}
			}
			else
			{
				dibujo.palabra_perdiste(new Punto(300,500));
			}
			
			if(nave.vidas_restantes()<=0)
			{
				perdiste=1;
			}
			activos=0;
			 for(int i=0;i<alienT1.Length;i++)
			 {
				if(alienT1[i].y<=0&&alienT1[i].activo()==1)
				{
					perdiste=1;
				}
				if(alienT2[i].y<=0&&alienT2[i].activo()==1)
				{
					perdiste=1;
				}
				if(alienT3[i].y<=0&&alienT3[i].activo()==1)
				{
					perdiste=1;
				}
				if(alienT1[i].activo()==1)
				{
					activos++;
				}
				if(alienT2[i].activo()==1)
				{
					activos++;
				}
				if(alienT3[i].activo()==1)
				{
					activos++;
				}

			 
			}
			 
			 if(activos==0)
			 {
			 	fase=2;
			 }
			 //reinciar nivel
			 if(jefe.activo()==0&&fase==2)
			 {
			 	avanzex=80;
			 	avanzey=60;
			 	fase=1;
			 	for(int i=0;i<alienT1.Length;i++)
			 	{
			 	alienT1[i].x=60+(avanzex*i);
			 	alienT1[i].y=500;
			 	alienT2[i].x=60+(avanzex*i);
			 	alienT2[i].y=560;
			 	alienT3[i].x=60+(avanzex*i);
			 	alienT3[i].y=620;
			 	alienT1[i].reactivar();
			 	alienT2[i].reactivar();
			 	alienT3[i].reactivar();
			 	
			 	}
			 	jefe.reactivar();
			 }
			 
			 
			SwapBuffers();
		}
		
		protected override void OnResize(EventArgs e)
		{
			GL.Viewport(0,0,Width,Height);
		}
		
		protected override void OnKeyPress(KeyPressEventArgs e)
		{
			if(e.KeyChar=='a')
			{
				nave.izquierda();
				
			}
			
			if(e.KeyChar=='d')
			{
				nave.derecha();
				
			}
			
			if(e.KeyChar=='l')
			{
				nave.disparar();
				
			}
			
			
			base.OnKeyPress(e);
		}
		
		
	}
	
	
}