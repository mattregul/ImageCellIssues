# ImageCellIssues

Issue loading ImageCell image using Forms 2.5.0 and PCL
- All three different code strategies have the same Listview and ImageCell code

Folders:
- [NS = .NET Standard Sample](https://github.com/mattregul/ImageCellIssues/tree/master/NS/NetStand)
- [PCL = PCL Sample](https://github.com/mattregul/ImageCellIssues/tree/master/PCL)
- [Shared = Shared Project Sample](https://github.com/mattregul/ImageCellIssues/tree/master/Shared/Shared)


```<?xml version="1.0" encoding="utf-8" ?>
<ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:NetStandard"
             x:Class="NetStandard.MainPage">
    <ContentPage.Content>
        <StackLayout Padding ="20">
            <Label Text="List of 50 Employees"></Label>
            <ListView x:Name="EmployeeListview">
                <ListView.ItemTemplate>
                    <DataTemplate>
                        <ImageCell
                            ImageSource="{Binding Source}"
                            Text="{Binding Name}"
                            Detail="{Binding Job}">
                        </ImageCell>
                    </DataTemplate>
                </ListView.ItemTemplate>
            </ListView>
        </StackLayout>
    </ContentPage.Content>
</ContentPage>```
