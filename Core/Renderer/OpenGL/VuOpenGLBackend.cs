using System;
using System.Collections.Generic;
using System.Text;

using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Windowing.GraphicsLibraryFramework;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL4;
using Vulpes.Core.Renderer;
using Vulpes.Core.Base;

namespace Vulpes.Core.Renderer.OpenGL
{
    public class Window : GameWindow
    {
        private readonly float[] _vertices =
        {
            -1f, -1f, 0f, // Bottom-left vertex
             1f, -1f, 0f, // Bottom-right vertex
             1f,  1f, 0f  // Top vertex
        };
        private int _vertexBufferObject;
        private int _vertexArrayObject;
        private VuOpenTKShader _shader;

        public Window(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings)
            : base(gameWindowSettings, nativeWindowSettings)
        {
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            if (KeyboardState.IsKeyDown(Keys.Escape))
            {
                Close();
            }

            base.OnUpdateFrame(e);
        }
        protected override void OnLoad()
        {
            base.OnLoad();
            GL.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            _vertexBufferObject = GL.GenBuffer();
            GL.BindBuffer(BufferTarget.ArrayBuffer, _vertexBufferObject);
            GL.BufferData(BufferTarget.ArrayBuffer, _vertices.Length * sizeof(float), _vertices, BufferUsageHint.StaticDraw);
            _vertexArrayObject = GL.GenVertexArray();
            GL.BindVertexArray(_vertexArrayObject);
            GL.VertexAttribPointer(0, 3, VertexAttribPointerType.Float, false, 3 * sizeof(float), 0);
            GL.EnableVertexAttribArray(0);
            _shader = new VuOpenTKShader(
                @"C:\WR\Vulpes\Core\Renderer\OpenGL\Shaders\VuOpenGLBackendVertex.glsl", 
                @"C:\WR\Vulpes\Core\Renderer\OpenGL\Shaders\VuOpenGLBackendFragment.glsl");
            _shader.Use();

        }
        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);
            GL.Clear(ClearBufferMask.ColorBufferBit);
            _shader.Use();
            GL.BindVertexArray(_vertexArrayObject);
            GL.DrawArrays(PrimitiveType.Triangles, 0, 3);
            SwapBuffers();
        }
        protected override void OnResize(ResizeEventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Size.X, Size.Y);
        }
        protected override void OnUnload()
        {
            GL.BindBuffer(BufferTarget.ArrayBuffer, 0);
            GL.BindVertexArray(0);
            GL.UseProgram(0);

            GL.DeleteBuffer(_vertexBufferObject);
            GL.DeleteVertexArray(_vertexArrayObject);

            GL.DeleteProgram(_shader.Handle);
            base.OnUnload();
        }
    }
}

namespace Vulpes.Core.Renderer.OpenGL
{
    class VuOpenGLBackend : VuRasterizationBackend
    {
        public override void Clear()
        {
            throw new NotImplementedException();
        }

        public override void DrawLines(VuVector<float>[] locations, VuColor[] colors)
        {
            throw new NotImplementedException();
        }

        public override void DrawPixel(VuVector<float>[] locations, VuColor[] colors)
        {
            throw new NotImplementedException();
        }

        public override void DrawTriangle(VuVector<float>[] locations, VuColor[] colors)
        {
            throw new NotImplementedException();
        }

        public override void Render()
        {
            throw new NotImplementedException();
        }

        public override void RuntimeInit()
        {
            var nativeWindowSettings = new NativeWindowSettings()
            {
                Size = new Vector2i(800, 600),
                Title = "Vulpe Application",
                Flags = ContextFlags.ForwardCompatible,
            };


            using (Window window = new Window(GameWindowSettings.Default, nativeWindowSettings))
            {
                window.Run();
            }

        }
    }
}
