using System;

namespace chapterTwoProjectTwo
{
    public class Distance
    {

        public float Miles { get; set; }
        public float Feet { get; set; }
        public float Kilometers { get; set; }

        public Distance(float distance, DistanceUnits unit)
        {
            switch (unit)
            {
                case DistanceUnits.FEET:
                    Feet = distance;
                    Miles = feetToMiles(distance);
                    Kilometers = feetToKilometers(distance);
                    break;
                case DistanceUnits.MILES:
                    Miles = distance;
                    Feet = milesToFeet(distance);
                    Kilometers = milesToKilometers(distance);
                    break;
                case DistanceUnits.KILOMETERS:
                    Kilometers = distance;
                    Feet = kilometersToFeet(distance);
                    Miles = kilometersToMiles(distance);
                    break;
                default:
                    break;
            }
        }

        private float milesToFeet(float miles) => Feet = miles * 5280f;
        private float milesToKilometers(float miles) => Kilometers = miles * 1.609344f;

        private float feetToMiles(float feet) => Miles = feet * 0.0001893939f;
        private float feetToKilometers(float feet) => Kilometers = feet * 0.0003048f;

        private float kilometersToFeet(float kilometers) => Feet = kilometers * 3280.839928f;
        private float kilometersToMiles(float kilometers) => Miles = kilometers * 0.6213712f;

    }
}