SELECT Country.Continent, FLOOR(SUM(City.Population) / Count(City.Name))
FROM City
JOIN Country ON Country.Code = City.CountryCode
GROUP BY Country.Continent