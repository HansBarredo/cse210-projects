class Rectangle : Shape
{
    private double _length;
    private double _width;

    public double GetLength(){
        return _length;
    }

    public void SetLength(double length){
        _length = length;
    }

    public double GetWidth(){
        return _width;
    }

    public void SethWidth(double width){
        _width = width;
    }
    
    public override double GetArea()
    {
        return _length * _width;
    }
}