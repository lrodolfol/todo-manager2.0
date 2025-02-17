﻿// See https://aka.ms/new-console-template for more information
using CardsConsumers.RabbitMq;
using TodoDB = CardsConsumers.Todo;
using CardsManagerLib.Models.Data.Dtos;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

Console.WriteLine("===App Running===");
Console.WriteLine("-");

do
{
    ConsumerQueueTodo co = new ConsumerQueueTodo();
    co.Consume();
} while (1 == 1);


CreateCardDto dto = new CreateCardDto();
dto.title = "Title here";
dto.DeadLine = DateTime.Parse("2022-06-06");
dto.UserStory = "A User Story to many peoples";
dto.Priority = CardsManagerLib.Enums.Priority.ALTO;

TodoDB.Connection c = new TodoDB.Connection();
c.Insert(dto);
c.Delete(9);