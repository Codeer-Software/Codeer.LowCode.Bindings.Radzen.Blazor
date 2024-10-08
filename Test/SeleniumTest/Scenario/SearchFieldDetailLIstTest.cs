﻿using OpenQA.Selenium;
using SeleniumTest.PageObject;

namespace SeleniumTest.Scenario;

public class SearchFieldDetailListTest
{
    IWebDriver _driver = default!;

    [SetUp]
    public void SetUp()
    {
        _driver = WebDriverManager.Driver;
        _driver.Url = WebDriverManager.Domain + "/Main/ReadDetailListData";
    }

    [TearDown]
    public void TearDown()
        => WebDriverManager.FailedCleanup();

    [Test]
    public void CheckBoxの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();

        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();
        var readDetailListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();
        WebDriverManager.WaitLoading();

        readDetailListDataDetailPage.Detail.Search.Fields.Check.Select.Edit("true");
        readDetailListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDetailListDataDetailPage.Detail.List.Items.Count.Is(1);
        readDetailListDataDetailPage.Detail.List.Items.GetItem(0).Check.Checked.Is(true);

        readDetailListDataDetailPage.Detail.Search.Fields.Check.Select.Edit("false");
        readDetailListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDetailListDataDetailPage.Detail.List.Items.Count.Is(1);
        readDetailListDataDetailPage.Detail.List.Items.GetItem(0).Check.Checked.Is(false);

        readDetailListDataDetailPage.Detail.Search.Fields.Check.Select.Edit("");
        readDetailListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readDetailListDataDetailPage.Detail.List.Items.Count.Is(16);
    }

    [Test]
    public void Toggleの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();
        //true検索
        readListDataDetailPage.Detail.Search.Fields.Toggle.Select.Edit("true");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.GetItem(0).Toggle.Checked.IsTrue();
        //false検索
        readListDataDetailPage.Detail.Search.Fields.Toggle.Select.Edit("false");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.GetItem(0).Toggle.Checked.IsFalse();
        //空にした場合は条件はクリアされる URLのパラメータも消える
        readListDataDetailPage.Detail.Search.Fields.Toggle.Select.Edit("");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(16);
    }

    [Test]
    public void Switchの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();
        //true検索
        readListDataDetailPage.Detail.Search.Fields.Switch.Select.Edit("true");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.GetItem(0).Switch.Checked.IsTrue();
        //false検索
        readListDataDetailPage.Detail.Search.Fields.Switch.Select.Edit("false");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.GetItem(0).Switch.Checked.IsFalse();
        //空にした場合は条件はクリアされる URLのパラメータも消える
        readListDataDetailPage.Detail.Search.Fields.Switch.Select.Edit("");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(16);
    }

    [Test]
    public void Dateの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();

        //From 検索 みつからない
        readListDataDetailPage.Detail.Search.Fields.Date.StartDate.Edit(2024, 05, 08);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(0);

        //From 検索 みつからる
        readListDataDetailPage.Detail.Search.Fields.Date.StartDate.Edit(2024, 05, 05);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(1);

        readListDataDetailPage.Detail.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(16);

        // TO 検索 みつからない
        readListDataDetailPage.Detail.Search.Fields.Date.EndDate.Edit(2023, 12, 01);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(0);

        // TO 検索 みつかる
        readListDataDetailPage.Detail.Search.Fields.Date.EndDate.Edit(2024, 05, 05);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(1);

        readListDataDetailPage.Detail.Search.Fields.Date.StartDate.Clear();
        readListDataDetailPage.Detail.Search.Fields.Date.EndDate.Clear();

        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(16);
    }

    [Test]
    public void DateTimeの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();

        //From 検索 みつからない
        readListDataDetailPage.Detail.Search.Fields.DateTime.StartDate.Edit(2024, 05, 08, 01, 01);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(0);

        //From 検索 みつからる
        readListDataDetailPage.Detail.Search.Fields.DateTime.StartDate.Edit(2024, 05, 05, 01, 01);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(1);

        readListDataDetailPage.Detail.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(16);

        // TO 検索 みつからない
        readListDataDetailPage.Detail.Search.Fields.DateTime.EndDate.Edit(2023, 12, 01, 01, 01);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(0);

        // TO 検索 みつかる
        readListDataDetailPage.Detail.Search.Fields.DateTime.EndDate.Edit(2024, 05, 06, 13, 01);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(1);

        readListDataDetailPage.Detail.Search.Fields.DateTime.StartDate.Clear();
        readListDataDetailPage.Detail.Search.Fields.DateTime.EndDate.Clear();

        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(16);
    }

    [Test]
    public void Linkの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();
        readListDataDetailPage.Detail.Search.Fields.Link.Search.Click();
        readListDataDetailPage.Detail.Search.Fields.Link.LinkList.Items.GetItem(1).Code.ReadOnlyText.Click();
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.GetItem(0).Link.ReadOnlyText.Text.Is("BBB");
    }

    [Test]
    public void Numberの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();

        //Min 検索 みつからない
        readListDataDetailPage.Detail.Search.Fields.Number.Min.Edit("124");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(0);

        //Min 検索 みつからる
        readListDataDetailPage.Detail.Search.Fields.Number.Min.Edit("123");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(1);

        readListDataDetailPage.Detail.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(16);

        // Max 検索 みつからない
        readListDataDetailPage.Detail.Search.Fields.Number.Max.Edit("122");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(0);

        // Max 検索 みつかる
        readListDataDetailPage.Detail.Search.Fields.Number.Max.Edit("124");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(1);
    }

    [Test]
    public void Radioの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();

        readListDataDetailPage.Detail.Search.Fields.RadioGroup.Select.Edit("B");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.GetItem(0).RadioA.Input.Checked.IsFalse();
        readListDataDetailPage.Detail.List.Items.GetItem(0).RadioB.Input.Checked.IsTrue();
        readListDataDetailPage.Detail.List.Items.GetItem(0).RadioC.Input.Checked.IsFalse();

        // Not検索
        readListDataDetailPage.Detail.Search.Fields.RadioGroup.Select.Edit("B");
        readListDataDetailPage.Detail.Search.Fields.RadioGroup.IsNot.Edit(true);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(15);
    }

    [Test]
    public void Selectの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();
        readListDataDetailPage.Detail.Search.Fields.Select.Select.Edit("B");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.GetItem(0).Select.ReadOnlyText.Text.Is("B");


        // Not検索
        readListDataDetailPage.Detail.Search.Fields.Select.Select.Edit("B");
        readListDataDetailPage.Detail.Search.Fields.Select.IsNot.Edit(true);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(15);
    }

    [Test]
    public void SelectLinkの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();
        readListDataDetailPage.Detail.Search.Fields.SelectLink.Select.Edit("CCC");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.GetItem(0).SelectLink.ReadOnlyText.Text.Is("CCC");

        // Not検索
        readListDataDetailPage.Detail.Search.Fields.SelectLink.Select.Edit("CCC");
        readListDataDetailPage.Detail.Search.Fields.SelectLink.IsNot.Edit(true);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(15);
    }

    [Test]
    public void Textの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();
        readListDataDetailPage.Detail.Search.Fields.Text.Text.Edit("abc");
        readListDataDetailPage.Detail.Search.Fields.Text.Match.Edit("完全一致");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.GetItem(0).Text.ReadOnlyText.Text.Is("abc");
        readListDataDetailPage.Detail.List.Items.Count.Is(1);

        readListDataDetailPage.Detail.Search.Clear.Click();

        // Like 検索
        readListDataDetailPage.Detail.Search.Fields.Text.Text.Edit("b");
        readListDataDetailPage.Detail.Search.Fields.Text.Match.Edit("部分一致");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.GetItem(0).Text.ReadOnlyText.Text.Is("abc");
        readListDataDetailPage.Detail.List.Items.Count.Is(1);
    }


    [Test]
    public void Timeの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();

        //From 検索 みつからない
        readListDataDetailPage.Detail.Search.Fields.Time.StartTime.Edit(19, 01);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(0);

        //From 検索 みつからる
        readListDataDetailPage.Detail.Search.Fields.Time.StartTime.Edit(19, 00);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(1);

        readListDataDetailPage.Detail.Search.Clear.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(16);

        readListDataDetailPage.Detail.Search.Clear.Click();

        // TO 検索 みつからない
        readListDataDetailPage.Detail.Search.Fields.Time.EndTime.Edit(18, 59);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(0);

        // TO 検索 みつかる
        readListDataDetailPage.Detail.Search.Fields.Time.EndTime.Edit(19, 00);
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(1);

        readListDataDetailPage.Detail.Search.Fields.Time.StartTime.Clear();
        readListDataDetailPage.Detail.Search.Fields.Time.EndTime.Clear();

        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(16);
    }

    [Test]
    public void Fileの検索()
    {
        var readListDataListPage = _driver.AttachReadDetailListDataListPage();
        readListDataListPage.List.Items.GetItem(2).NavigateToDetail.Click();

        var readListDataDetailPage = _driver.AttachReadDetailListDataDetailPage();
        readListDataDetailPage.Detail.Search.Fields.File.FileName.Edit("data.txt");
        readListDataDetailPage.Detail.Search.Fields.File.FileNameMatch.Edit("完全一致");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        // readListDataDetailPage.Detail.List.Items.GetItem(0).File.Input.Text.Is("data.txt");
        readListDataDetailPage.Detail.List.Items.Count.Is(1);


        // Like 検索
        readListDataDetailPage.Detail.Search.Fields.File.FileName.Edit("ta");
        readListDataDetailPage.Detail.Search.Fields.File.FileNameMatch.Edit("部分一致");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        // readListDataDetailPage.Detail.List.Items.GetItem(0).File.Input.Text.Is("data.txt");
        readListDataDetailPage.Detail.List.Items.Count.Is(1);

        readListDataDetailPage.Detail.Search.Clear.Click();

        // File サイズ 検索
        readListDataDetailPage.Detail.Search.Fields.File.MinFileSize.Edit("10");
        readListDataDetailPage.Detail.Search.Fields.File.MaxFileSize.Edit("11");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(1);

        readListDataDetailPage.Detail.Search.Fields.File.MinFileSize.Edit("11");
        readListDataDetailPage.Detail.Search.Fields.File.MaxFileSize.Edit("12");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(0);

        readListDataDetailPage.Detail.Search.Fields.File.MinFileSize.Edit("");
        readListDataDetailPage.Detail.Search.Fields.File.MaxFileSize.Edit("");
        readListDataDetailPage.Detail.Search.Search.Click();
        WebDriverManager.WaitLoading();
        readListDataDetailPage.Detail.List.Items.Count.Is(16);
    }
}
