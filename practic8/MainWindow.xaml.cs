﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Serdes;


namespace practic8
{
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SerializeButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаем объект для сериализации
            Person person = new Person { Name = "Jime, Kayle", Age = 25, Height = 196, Weight = 80};

            // Сериализуем объект в строку JSON
            string json = System.Text.Json.JsonSerializer.Serialize(person);

            // Отображаем сериализованный JSON в текстовом поле
            jsonTextBox.Text = json;
        }

        private void DeserializeButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем сериализованный JSON из текстового поля
            string json = jsonTextBox.Text;

            // Десериализуем JSON-строку в объект
            Person person = System.Text.Json.JsonSerializer.Deserialize<Person>(json);

            // Выводим десериализованный объект в консоль
            jsonTextBox.Text = person.ToString();
        }
        private void teme_Click(object sender, RoutedEventArgs e)
        {
            if(App.There == "GreenRed")
            {
                App.There = "purpleblue";
            }
            else if(App.There == "purpleblue")
            {
                App.There = "beigedelicateblue";
            }
            else
            {
                App.There = "GreenRed";
            }
        }
    }
}
