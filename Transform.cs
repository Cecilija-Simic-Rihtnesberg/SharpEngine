namespace SharpEngine {
    
    public class Transform {
        
        public Vector CurrentScale { get; private set; }
        public Vector Position { get; private set; }
        public Matrix Matrix => Matrix.Translation(Position) * Matrix.Scale(CurrentScale);

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
            
        }
    }
}