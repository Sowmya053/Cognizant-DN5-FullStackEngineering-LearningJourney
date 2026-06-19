using System;

class House
{
    public string Walls;
    public string Roof;
}

class HouseBuilder
{
    private House house = new House();

    public HouseBuilder BuildWalls()
    {
        house.Walls = "Concrete Walls";
        return this;
    }

    public HouseBuilder BuildRoof()
    {
        house.Roof = "Concrete Roof";
        return this;
    }

    public House GetHouse()
    {
        return house;
    }
}
