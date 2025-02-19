using System;

class Circle : Shape
{
    private double _radius;

    public double GetRadius(){
        return _radius;
    }

    public void SetRadius(double radius){
        _radius = radius;
    }

    public override double GetArea()
    {
        return 3.14 * Math.Pow(_radius,2);
    }
}