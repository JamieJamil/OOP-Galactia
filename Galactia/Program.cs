using Galactia;
using System.Diagnostics.Metrics;
using static Galactia.SpaceObject;


StarType sun = new StarType();
#region Planets
Planet mercury = new Planet();
Planet venus = new Planet();
Planet earth = new Planet();
Planet mars = new Planet();
Planet jupiter = new Planet();
Planet saturn = new Planet();
Planet uranus = new Planet();
Planet neptune = new Planet();
#endregion
#region Moons
Moon luna = new Moon();
Moon titan = new Moon();
Moon phobos = new Moon();
Moon europe = new Moon();
Moon deimos = new Moon();
Moon ganymedes = new Moon();
Moon io = new Moon();
Moon mimas = new Moon();
#endregion



{
    sun.ID = 1;
    sun.Name = "Sun";
    sun.Type = StarType.Startype.YellowDwarf;
    sun.PositionToString = (new SpaceObject.Position() { X = 0, Y = 0 });
    sun.Temperature = 577800000;
    sun.PlanetList.Add(mercury);
    sun.PlanetList.Add(venus);
    sun.PlanetList.Add(earth);
    sun.PlanetList.Add(mars);
    sun.PlanetList.Add(jupiter);
    sun.PlanetList.Add(saturn);
    sun.PlanetList.Add(uranus);
    sun.PlanetList.Add(neptune);

    Console.WriteLine("Star System\n");
}

{
    mercury.ID = 1;
    mercury.Name = "Mercury";
    mercury.PositionToString = (new SpaceObject.Position() { X = 20, Y = 37 });
    mercury.Type = Planet.PlanetType.Terrestial;
    mercury.RotationPeriod = 1416;
    mercury.RevolutionPeriod = 88;
    mercury.Diameter = 4800;
    mercury.Distance(sun);
}

{
    venus.ID = 2;
    venus.Name = "Venus";
    venus.PositionToString = (new SpaceObject.Position() { X = 6, Y = 40 });
    venus.Type = Planet.PlanetType.Terrestial;
    venus.RotationPeriod = 5832;
    venus.RevolutionPeriod = 225;
    venus.Diameter = 12000;
}

{
    earth.ID = 3;
    earth.Name = "Earth";
    earth.PositionToString = (new SpaceObject.Position() { X = 24, Y = 37 });
    earth.Type = Planet.PlanetType.Terrestial;
    earth.RotationPeriod = 24;
    earth.RevolutionPeriod = 365;
    earth.Diameter = 12000;
}


{
    mars.ID = 4;
    mars.Name = "Mars";
    mars.PositionToString = (new SpaceObject.Position() { X = 20, Y = 40 });
    mars.Type = Planet.PlanetType.Terrestial;
    mars.RotationPeriod = 24;
    mars.RevolutionPeriod = 88;
    mars.Diameter = 6779;
}

{
    jupiter.ID = 5;
    jupiter.Name = "Jupiter";
    jupiter.PositionToString = (new SpaceObject.Position() { X = 43, Y = 38 });
    jupiter.Type = Planet.PlanetType.Gas_Giant;
    jupiter.RotationPeriod = 9925;
    jupiter.RevolutionPeriod = 12;
    jupiter.Diameter = 139820;
}

{
    saturn.ID = 6;
    saturn.Name = "Saturn";
    saturn.PositionToString = (new SpaceObject.Position() { X = 17, Y = 55 });
    saturn.Type = Planet.PlanetType.Gas_Giant;
    saturn.RotationPeriod = 696;
    saturn.RevolutionPeriod = 29;
    saturn.Diameter = 116460;
}

{
    uranus.ID = 7;
    uranus.Name = "Uranus";
    uranus.PositionToString = (new SpaceObject.Position() { X = 3, Y = 1 });
    uranus.Type = Planet.PlanetType.Giant;
    uranus.RotationPeriod = 17;
    uranus.RevolutionPeriod = 84;
    uranus.Diameter = 50724;
}

{
    neptune.ID = 8;
    neptune.Name = "Neptune";
    neptune.PositionToString = (new SpaceObject.Position() { X = 33, Y = 7 });
    neptune.Type = Planet.PlanetType.Giant;
    neptune.RotationPeriod = 16;
    neptune.RevolutionPeriod = 165;
    neptune.Diameter = 49224;
}

{
    luna.ID = 1;
    luna.Name = "Luna";
    luna.PositionToString = (new SpaceObject.Position() { X = 12, Y = 43 });
    luna.Type = Planet.PlanetType.Terrestial;
    luna.RotationPeriod = 648;
    luna.RevolutionPeriod = 27;
    luna.Diameter = 3474;
}

{
    titan.ID = 2;
    titan.Name = "Titan";
    titan.PositionToString = (new SpaceObject.Position() { X = 16, Y = 45 });
    titan.Type = Planet.PlanetType.Giant;
    titan.RotationPeriod = 384;
    titan.RevolutionPeriod = 16;
    titan.Diameter = 5149;
}

{
    phobos.ID = 3;
    phobos.Name = "Titan";
    phobos.PositionToString = (new SpaceObject.Position() { X = 16, Y = 45 });
    phobos.Type = Planet.PlanetType.Giant;
    phobos.RotationPeriod = 384;
    phobos.RevolutionPeriod = 16;
    phobos.Diameter = 5149;
}

{
    europe.ID = 4;
    europe.Name = "Titan";
    europe.PositionToString = (new SpaceObject.Position() { X = 16, Y = 45 });
    europe.Type = Planet.PlanetType.Giant;
    europe.RotationPeriod = 384;
    europe.RevolutionPeriod = 16;
    europe.Diameter = 5149;
}

{
    deimos.ID = 5;
    deimos.Name = "Titan";
    deimos.PositionToString = (new SpaceObject.Position() { X = 16, Y = 45 });
    deimos.Type = Planet.PlanetType.Giant;
    deimos.RotationPeriod = 384;
    deimos.RevolutionPeriod = 16;
    deimos.Diameter = 5149;
}

{
    ganymedes.ID = 6;
    ganymedes.Name = "Titan";
    ganymedes.PositionToString = (new SpaceObject.Position() { X = 16, Y = 45 });
    ganymedes.Type = Planet.PlanetType.Giant;
    ganymedes.RotationPeriod = 384;
    ganymedes.RevolutionPeriod = 16;
    ganymedes.Diameter = 5149;
}

{
    io.ID = 7;
    io.Name = "Titan";
    io.PositionToString = (new SpaceObject.Position() { X = 16, Y = 45 });
    io.Type = Planet.PlanetType.Giant;
    io.RotationPeriod = 384;
    io.RevolutionPeriod = 16;
    io.Diameter = 5149;
}

{
    mimas.ID = 8;
    mimas.Name = "Titan";
    mimas.PositionToString = (new SpaceObject.Position() { X = 16, Y = 45 });
    mimas.Type = Planet.PlanetType.Giant;
    mimas.RotationPeriod = 384;
    mimas.RevolutionPeriod = 16;
    mimas.Diameter = 5149;
}
