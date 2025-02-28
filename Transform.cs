namespace SharpEngine {
    public class Transform {
        public Vector CurrentScale { get; set; }
        public Vector Position { get; set; }
        public Vector Rotation { get; set; }
        public Matrix Matrix => Matrix.Translation(Position) * Matrix.Rotation(Rotation) * Matrix.Scale(CurrentScale);

        public Vector Forward => Matrix.Transform(Matrix, Vector.Forward, 0);
        public Vector Backward => Matrix.Transform(Matrix, Vector.Backward, 0);
        public Vector Left => Matrix.Transform(Matrix, Vector.Left, 0);
        public Vector Right => Matrix.Transform(Matrix, Vector.Right, 0);

        public Transform() {
            this.CurrentScale = new Vector(1, 1, 1);
        }
		
        public void Scale(float multiplier) {
            CurrentScale *= multiplier;
        }

        public void Move(Vector direction) {
            this.Position += direction;
        }

        public void Rotate(float zAngle) {
            var rotation = this.Rotation;
            rotation.z += zAngle;
            this.Rotation = rotation;
        }
    }
}

// namespace SharpEngine {
//     
//     public class Transform {
//         
//         public Vector CurrentScale { get; private set; }
//         public Vector Position { get; private set; }
//         public Vector Rotation { get; private set; }
//         public Matrix Matrix => Matrix.Rotation(Position) * Matrix.Rotation(Rotation) * Matrix.Rotation(CurrentScale);
//
//         public Transform() {
//             this.CurrentScale = new Vector(1, 1, 1);
//         }
// 		
//         public void Scale(float multiplier) {
//             CurrentScale *= multiplier;
//         }
//
//         public void Move(Vector direction) {
//             this.Position += direction;
//         }
//
//         public void Rotate(float zAngle) {
//             var rotation = this.Rotation;
//             rotation.z += zAngle;
//             this.Rotation = rotation;
//         }
//     }
// }