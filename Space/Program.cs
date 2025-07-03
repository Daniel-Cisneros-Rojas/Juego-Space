using System;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace Space
{
	class Program
	{
		public static void Main(string[] args)
		{
			Pantalla game=new Pantalla();
			game.Run();
		}
	}
}