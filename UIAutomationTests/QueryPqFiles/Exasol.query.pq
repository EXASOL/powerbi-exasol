﻿let
    Source = Exasol.Database("{server}", "Yes", null),
    ADVENTUREWORKSDW2014_Schema = Source{[Name="TEST",Kind="Schema"]}[Data]
in
    ADVENTUREWORKSDW2014_Schema