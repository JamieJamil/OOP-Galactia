using Galactica;
using System.Diagnostics.Metrics;
using static Galactica.SpaceObject;


StarType sun = new StarType();
#region PlanetsVariable
Planet mercury = new Planet();
Planet venus = new Planet();
Planet earth = new Planet();
Planet mars = new Planet();
Planet jupiter = new Planet();
Planet saturn = new Planet();
Planet uranus = new Planet();
Planet neptune = new Planet();
#endregion
#region MoonsVariable
Moon luna = new Moon();
Moon titan = new Moon();
Moon phobos = new Moon();
Moon europa = new Moon();
Moon deimos = new Moon();
Moon ganymedes = new Moon();
Moon io = new Moon();
Moon mimas = new Moon();
#endregion
#region 
{
sun.ID = 1;
sun.Name = "Sun";
sun.Type = StarType.Startype.YellowDwarf;
sun.PositionToString.X = 0;
sun.PositionToString.Y = 0;
sun.Temperature = 150000000;
sun.PlanetList.Add(mercury);
sun.PlanetList.Add(venus);
sun.PlanetList.Add(earth);
sun.PlanetList.Add(mars);
sun.PlanetList.Add(jupiter);
sun.PlanetList.Add(saturn);
sun.PlanetList.Add(uranus);
sun.PlanetList.Add(neptune);

Console.WriteLine($"" +
    $"Sar System\nName: {sun.Name}" +
    $"\nId: {sun.ID}" +
    $"\nStar type: {sun.Type}" +
    $"\nPosition: {sun.PositionToString} ");
}
#endregion
#region PlanetsData
{
    mercury.ID = 1;
    mercury.Name = "Mercury";
    mercury.PositionToString.X = 21;
    mercury.PositionToString.Y = 38;
    mercury.Type = Planet.PlanetType.Terrestial;
    mercury.RotationPeriod = 1416;
    mercury.RevolutionPeriod = 88;
    mercury.Diameter = 4880000;
    mercury.Distance(sun);
}

{
    venus.ID = 2;
    venus.Name = "Venus";
    venus.PositionToString.X = 6;
    venus.PositionToString.Y = 40;
    venus.Type = Planet.PlanetType.Terrestial;
    venus.RotationPeriod = 5832;
    venus.RevolutionPeriod = 225;
    venus.Diameter = 6051800;
    venus.Distance(sun);
}

{
    earth.ID = 3;
    earth.Name = "Earth";
    earth.PositionToString.X = 24;
    earth.PositionToString.Y = 37;
    earth.Type = Planet.PlanetType.Terrestial;
    earth.RotationPeriod = 24;
    earth.RevolutionPeriod = 365;
    earth.Diameter = 1272000;
    earth.Distance(sun);
    earth.MoonList.Add(luna);
}

{
    mars.ID = 4;
    mars.Name = "Mars";
    mars.PositionToString.X = 20;
    mars.PositionToString.Y = 40;
    mars.Type = Planet.PlanetType.Terrestial;
    mars.RotationPeriod = 25;
    mars.RevolutionPeriod = 687;
    mars.Diameter = 6779000;
    mars.Distance(sun);
    mars.MoonList.Add(phobos);
    mars.MoonList.Add(deimos);
}

{
    jupiter.ID = 5;
    jupiter.Name = "Jupiter";
    jupiter.PositionToString.X = 43;
    jupiter.PositionToString.Y = 38;
    jupiter.Type = Planet.PlanetType.Gas_Giant;
    jupiter.RotationPeriod = 9925;
    jupiter.RevolutionPeriod = 4377;
    jupiter.Diameter = 139820000;
    jupiter.Distance(sun);
    jupiter.MoonList.Add(europa);
    jupiter.MoonList.Add(ganymedes);
    jupiter.MoonList.Add(io);
}

{
    saturn.ID = 6;
    saturn.Name = "Saturn";
    saturn.PositionToString.X = 17;
    saturn.PositionToString.Y = 55;
    saturn.Type = Planet.PlanetType.Gas_Giant;
    saturn.RotationPeriod = 11;
    saturn.RevolutionPeriod = 10578;
    saturn.Diameter = 116460000;
    saturn.Distance(sun);
    saturn.MoonList.Add(titan);
    saturn.MoonList.Add(mimas);
}

{
    uranus.ID = 7;
    uranus.Name = "Uranus";
    uranus.PositionToString.X = 3;
    uranus.PositionToString.Y = 1;
    uranus.Type = Planet.PlanetType.Giant;
    uranus.RotationPeriod = 17;
    uranus.RevolutionPeriod = 30639;
    uranus.Diameter = 50724000;
    uranus.Distance(sun);
}

{
    neptune.ID = 8;
    neptune.Name = "Neptune";
    neptune.PositionToString.X = 33;
    neptune.PositionToString.Y = 7;
    neptune.Type = Planet.PlanetType.Giant;
    neptune.RotationPeriod = 16;
    neptune.RevolutionPeriod = 60184;
    neptune.Diameter = 49244000;
    neptune.Distance(sun);
}
#endregion
#region MoonData
{
    // Orbits Earth
    luna.ID = 1;
    luna.Name = "Luna";
    luna.PositionToString.X = 12;
    luna.PositionToString.Y = 43;
    luna.Type = Planet.PlanetType.Terrestial;
    luna.RotationPeriod = 655;
    luna.RevolutionPeriod = 27;
    luna.Diameter = 3474800;
    luna.Orbiting = earth;
    luna.Distance(earth);
}

{
    // Orbits Saturn
    titan.ID = 2;
    titan.Name = "Titan";
    titan.PositionToString.X = 16;
    titan.PositionToString.Y = 45;
    titan.Type = Planet.PlanetType.Giant;
    titan.RotationPeriod = 384;
    titan.RevolutionPeriod = 16;
    titan.Diameter = 5149500;
    titan.Orbiting = saturn;
    titan.Distance(saturn);
}

{
    // Orbits Mars
    phobos.ID = 3;
    phobos.Name = "Phobos";
    phobos.PositionToString.X = 24;
    phobos.PositionToString.Y = 37;
    phobos.Type = Planet.PlanetType.Giant;
    phobos.RotationPeriod = 8;
    phobos.RevolutionPeriod = 8;
    phobos.Diameter = 22500;
    phobos.Orbiting = mars;
    phobos.Distance(mars);
}

{
    // Orbits Jupiter
    europa.ID = 4;
    europa.Name = "Europa";
    europa.PositionToString.X = 40;
    europa.PositionToString.Y = 40;
    europa.Type = Planet.PlanetType.Giant;
    europa.RotationPeriod = 85;
    europa.RevolutionPeriod = 3;
    europa.Diameter = 3120600;
    europa.Orbiting = jupiter;
    europa.Distance(jupiter);
}

{
    // Orbits Mars
    deimos.ID = 5;
    deimos.Name = "Deimos";
    deimos.PositionToString.X = 16;
    deimos.PositionToString.Y = 44;
    deimos.Type = Planet.PlanetType.Giant;
    deimos.RotationPeriod = 30;
    deimos.RevolutionPeriod = 1;
    deimos.Diameter = 12400;
    deimos.Orbiting = mars;
    deimos.Distance(mars);
}

{
    // Orbits Jupiter
    ganymedes.ID = 6;
    ganymedes.Name = "Ganymedes";
    ganymedes.PositionToString.X = 46;
    ganymedes.PositionToString.Y = 42;
    ganymedes.Type = Planet.PlanetType.Giant;
    ganymedes.RotationPeriod = 172;
    ganymedes.RevolutionPeriod = 7;
    ganymedes.Diameter = 5268000;
    ganymedes.Orbiting = jupiter;
    ganymedes.Distance(jupiter);
}

{
    // Orbits Jupiter
    io.ID = 7;
    io.Name = "Io";
    io.PositionToString.X = 43;
    io.PositionToString.Y = 36;
    io.Type = Planet.PlanetType.Giant;
    io.RotationPeriod = 42;
    io.RevolutionPeriod = 2;
    io.Diameter = 3640000;
    io.Orbiting = jupiter;
    io.Distance(jupiter);
}

{
    // Orbits Saturn
    mimas.ID = 8;
    mimas.Name = "Mimas";
    mimas.PositionToString.X = 15;
    mimas.PositionToString.Y = 52;
    mimas.Type = Planet.PlanetType.Giant;
    mimas.RotationPeriod = 23;
    mimas.RevolutionPeriod = 1;
    mimas.Diameter = 396400;
    mimas.Orbiting = saturn;
    mimas.Distance(saturn);
}
#endregion
#region Foreach
// Foreach to output data froms lists
foreach (var planet in sun.PlanetList)
{
    Console.WriteLine($"-------------------------------------------------" +
        $"\nName: {planet.Name}" +
        $"\nId: {planet.ID}" +
        $"\ntype: {planet.Type}" +
        $"\nDiameter: {planet.Diameter}" +
        $"\nRevolution Period: {planet.RevolutionPeriod}" +
        $"\nRotation Period: {planet.RotationPeriod}" +
        $"\nPosition: {planet.PositionToString}" +
        $"\nDistance to the sun: {planet.Distance(sun)} KM ");
    foreach (var moon in planet.MoonList)
    {
        Console.WriteLine($"" +
            $"\n    Name: {moon.Name}" +
            $"\n    Id: {moon.ID}" +
            $"\n    Moon of: {moon.Orbiting.Name}" +
            $"\n    Diameter: {moon.Diameter}" +
            $"\n    Revolution Period: {moon.RevolutionPeriod}" +
            $"\n    Rotation Period: {moon.RotationPeriod}" +
            $"\n    Position: {moon.PositionToString}" +
            $"\n    Distance to the sun: {moon.Distance(planet)} KM ");
    }
}
#endregion