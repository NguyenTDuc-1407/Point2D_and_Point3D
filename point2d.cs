class point2d
{
    private float x;
    private float y;
    public point2d() { }

    public point2d(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float getX()
    {
        return x;
    }
    public void setX(float x)
    {
        this.x = x;
    }
    public float getY()
    {
        return y;
    }
    public void setY(float y)
    {
        this.y = y;
    }
    public void setPoint2d(float x, float y)
    {
        this.x = x;
        this.y = y;

    }
    public float getPoint2d()
    {
        return 2;

    }
    public override string ToString()
    {
        return "point 2d "
                + getPoint2d()
                + ", which is a subclass of "
                + base.ToString();
    }

}