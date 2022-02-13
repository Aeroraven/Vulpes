using System;
using System.Collections.Generic;
using System.Text;
using Vulpes.Core.Base;
using Vulpes.Core.Image;
namespace Vulpes.Render.Component
{
    class VuRenderScene
    {
        protected VuBitmapBuffer image;
        protected float sceneWidth;
        protected float sceneHeight;
        public VuRenderScene(int iw,int ih,float sw,float sh)
        {
            image = new VuBitmapBuffer(iw, ih);
            sceneWidth = sw;
            sceneHeight = sh;
        }
        public float ImageSpaceWidth
        {
            get
            {
                return image.Width;
            }
        }
        public float ImageSpaceHeight
        {
            get
            {
                return image.Height;
            }
        }
        public float SceneWidth
        {
            get
            {
                return sceneWidth;
            }
        }
        public float SceneHeight
        {
            get
            {
                return sceneHeight;
            }
        }
    }
}
