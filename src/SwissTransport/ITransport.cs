﻿namespace SwissTransport
{
    public interface ITransport
    {
        Stations GetStations(string query);
        StationBoardRoot GetStationBoard(string station);
        Connections GetConnections(string fromStation, string toStation, string date, string time);
        Stations GetNearestStation(string xCoord, string yCoord);
    }
}