class point3d : point2d
{
    float z;
    public float getZ()
    {
        return z;
    }
    public void setZ(float z)
    {
        this.z = z;

    }
    public point3d() { }
    public point3d(float x, float y, float z) : base(x, y)
    {
        this.z = z;

    }
    public override string ToString()
    {
        return "point 3d "
                + getZ()
                + ", which is a subclass of "
                + base.ToString();
    }

}