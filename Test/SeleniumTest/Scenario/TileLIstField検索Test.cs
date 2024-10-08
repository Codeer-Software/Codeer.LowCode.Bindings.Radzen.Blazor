﻿using OpenQA.Selenium;
using SeleniumTest.PageObject;

namespace SeleniumTest.Scenario;

public class TileListField検索Test
{
    IWebDriver _driver = default!;

    [SetUp]
    public void SetUp()
    {
        _driver = WebDriverManager.Driver;
        _driver.Url = WebDriverManager.Domain + "/Main/ReadTileListData";
    }

    [TearDown]
    public void TearDown()
        => WebDriverManager.FailedCleanup();

    [Test]
    public void Listの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();

        readListDataListPage.Search.Fields.List.Select.Edit("行を持つ");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List.Select.Edit("行を持たない");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(1);

        readListDataListPage.Search.Fields.List.Select.Edit("");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
    }

    [Test]
    public void CheckBoxの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        readListDataListPage.Search.Fields.List_Check.Select.Edit("true");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);

        readListDataListPage.Search.Fields.List_Check.Select.Edit("false");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List_Check.Select.Edit("");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadTileListData");
    }


    [Test]
    public void Toggleの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        readListDataListPage.Search.Fields.List_Toggle.Select.Edit("true");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);

        readListDataListPage.Search.Fields.List_Toggle.Select.Edit("false");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List_Toggle.Select.Edit("");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadTileListData");
    }

    [Test]
    public void Switchの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        readListDataListPage.Search.Fields.List_Switch.Select.Edit("true");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);

        readListDataListPage.Search.Fields.List_Switch.Select.Edit("false");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List_Switch.Select.Edit("");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadTileListData");
    }

    [Test]
    public void Dateの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        //From 検索 みつからない
        readListDataListPage.Search.Fields.List_Date.StartDate.Edit(2024, 05, 08);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(0);

        //From 検索 みつからる
        readListDataListPage.Search.Fields.List_Date.StartDate.Edit(2024, 05, 05);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);

        // TO 検索 みつからない
        readListDataListPage.Search.Fields.List_Date.EndDate.Edit(2023, 12, 01);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(0);

        // TO 検索 みつかる
        readListDataListPage.Search.Fields.List_Date.EndDate.Edit(2024, 05, 05);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List_Date.StartDate.Clear();
        readListDataListPage.Search.Fields.List_Date.EndDate.Clear();

        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadTileListData");
    }


    [Test]
    public void DateTimeの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        //From 検索 みつからない
        readListDataListPage.Search.Fields.List_DateTime.StartDate.Edit(2024, 05, 08, 01, 01);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(0);

        //From 検索 みつからる
        readListDataListPage.Search.Fields.List_DateTime.StartDate.Edit(2024, 05, 05, 01, 01);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);

        // TO 検索 みつからない
        readListDataListPage.Search.Fields.List_DateTime.EndDate.Edit(2023, 12, 01, 01, 01);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(0);

        // TO 検索 みつかる
        readListDataListPage.Search.Fields.List_DateTime.EndDate.Edit(2024, 05, 06, 13, 01);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List_DateTime.StartDate.Clear();
        readListDataListPage.Search.Fields.List_DateTime.EndDate.Clear();

        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadTileListData");
    }

    [Test]
    public void Numberの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        //min検索 みつからない
        readListDataListPage.Search.Fields.List_Number.Min.Edit("124");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(0);

        //min検索 みつかる
        readListDataListPage.Search.Fields.List_Number.Min.Edit("123");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Clear.Click();

        //max検索 みつからない
        readListDataListPage.Search.Fields.List_Number.Max.Edit("122");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(0);

        //max検索 みつかる
        readListDataListPage.Search.Fields.List_Number.Max.Edit("123");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);
    }

    [Test]
    public void RadioGroupの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        // みつからない
        readListDataListPage.Search.Fields.List_RadioGroup.Select.Edit("A");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(0);

        readListDataListPage.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);

        // 2件みつかる
        readListDataListPage.Search.Fields.List_RadioGroup.Select.Edit("B");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List_RadioGroup.Select.Edit("");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadTileListData");
    }

    [Test]
    public void Selectの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        readListDataListPage.Search.Fields.List_Select.Select.Edit("B");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);

        readListDataListPage.Search.Fields.List_Select.Select.Edit("B");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List_Select.Select.Edit("");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadTileListData");
    }


    [Test]
    public void Textの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        readListDataListPage.Search.Fields.List_Text.Text.Edit("abc");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);

        readListDataListPage.Search.Fields.List_Text.Text.Edit("abc");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List_Text.Text.Edit("");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadTileListData");
    }

    [Test]
    public void TextのLike検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        readListDataListPage.Search.Fields.List_Text.Text.Edit("abc");
        readListDataListPage.Search.Fields.List_Text.Match.Edit("完全一致");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);

        readListDataListPage.Search.Fields.List_Text.Text.Edit("c");
        readListDataListPage.Search.Fields.List_Text.Match.Edit("部分一致");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List_Text.Text.Edit("");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadTileListData");
    }


    [Test]
    public void Timeの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        //開始時刻 検索 みつからない
        readListDataListPage.Search.Fields.List_Time.StartTime.Edit(19, 06);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(0);

        readListDataListPage.Search.Clear.Click();

        //開始時刻 検索 みつからる
        readListDataListPage.Search.Fields.List_Time.StartTime.Edit(19, 00);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        //終了時刻 検索 みつからない
        readListDataListPage.Search.Fields.List_Time.EndTime.Edit(18, 59);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(0);

        readListDataListPage.Search.Clear.Click();

        //終了時刻 検索 みつからる
        readListDataListPage.Search.Fields.List_Time.EndTime.Edit(19, 00);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);


        //開始と終了
        readListDataListPage.Search.Fields.List_Time.StartTime.Edit(19, 00);
        readListDataListPage.Search.Fields.List_Time.EndTime.Edit(19, 00);
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List_Time.StartTime.Clear();
        readListDataListPage.Search.Fields.List_Time.EndTime.Clear();
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadTileListData");
    }

    [Test]
    public void Fileの検索()
    {
        var readListDataListPage = _driver.AttachReadTileListDataListPage();
        // File名 Equals 検索
        readListDataListPage.Search.Fields.List_File.FileName.Edit("data.txt");
        readListDataListPage.Search.Fields.List_File.FileNameMatch.Edit("完全一致");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        // File名 Like 検索
        readListDataListPage.Search.Fields.List_File.FileName.Edit("ata");
        readListDataListPage.Search.Fields.List_File.FileNameMatch.Edit("部分一致");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Clear.Click();

        // File サイズ 検索
        readListDataListPage.Search.Fields.List_File.MinFileSize.Edit("10");
        readListDataListPage.Search.Fields.List_File.MaxFileSize.Edit("11");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(2);

        readListDataListPage.Search.Fields.List_File.MinFileSize.Edit("11");
        readListDataListPage.Search.Fields.List_File.MaxFileSize.Edit("12");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(0);

        readListDataListPage.Search.Fields.List_File.MinFileSize.Edit("");
        readListDataListPage.Search.Fields.List_File.MaxFileSize.Edit("");
        readListDataListPage.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataListPage.List.Items.Count.Is(3);
        _driver.Url.Is(WebDriverManager.Domain + "/Main/ReadTileListData");
    }
}
