using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace proof_of_concept_find_shape.classes
{
    public class MinMax
    {
        public float xMin = float.PositiveInfinity;
        public float yMin = float.PositiveInfinity;
        public float xMax = float.NegativeInfinity;
        public float yMax = float.NegativeInfinity;

        public MinMax(TilePoints tp)
        {
            setMinMaxPoints(tp);
        }
        public MinMax(TilePoints[] tp)
        {
            for (int i = 0; i < tp.Length; i++) {
                setMinMaxPoints(tp[i]);
            }
        }

        private void setMinMaxPoints(TilePoints tp)
        {
            setMinMax(tp.position);
            for (int i2 = 0; i2 < tp.points.Length; i2++)
            {
                setMinMax(tp.points[i2]);
            }
        }

        private void setMinMax(Vector2 position)
        {
            if (xMax < position.X) xMax = position.X;
            if (yMax < position.Y) yMax = position.Y;
            if (xMin > position.X) xMin = position.X;
            if (yMin > position.Y) yMin = position.Y;
        }
    }
}
