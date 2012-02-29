using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Coypu;
using Coypu.Actions;
using Coypu.Predicates;

namespace CoypuTables
{
    public abstract class DelegatingElementScope : Element, Scope<ElementScope>
    {
        private readonly ElementScope innerElement;

        protected DelegatingElementScope(ElementScope innerElement)
        {
            this.innerElement = innerElement;
        }

        public ElementScope Check(string locator)
        {
            return innerElement.Check(locator);
        }

        public ElementScope Choose(string locator)
        {
            return innerElement.Choose(locator);
        }

        public ElementScope ClickButton(string locator)
        {
            return innerElement.ClickButton(locator);
        }

        public ElementScope ClickButton(string locator, Func<bool> until, TimeSpan waitBetweenRetries)
        {
            return innerElement.ClickButton(locator, until, waitBetweenRetries);
        }

        public ElementScope ClickLink(string locator)
        {
            return innerElement.ClickLink(locator);
        }

        public ElementScope ClickLink(string locator, Func<bool> until, TimeSpan waitBetweenRetries)
        {
            return innerElement.ClickLink(locator, until, waitBetweenRetries);
        }

        public ElementScope ConsideringInvisibleElements()
        {
            return innerElement.ConsideringInvisibleElements();
        }

        public ElementScope ConsideringOnlyVisibleElements()
        {
            return innerElement.ConsideringOnlyVisibleElements();
        }

        public string ExecuteScript(string javascript)
        {
            return innerElement.ExecuteScript(javascript);
        }

        public FillInWith FillIn(Element element)
        {
            return innerElement.FillIn(element);
        }

        public FillInWith FillIn(string locator)
        {
            return innerElement.FillIn(locator);
        }

        public IEnumerable<Element> FindAllCss(string cssSelector)
        {
            return innerElement.FindAllCss(cssSelector);
        }

        public IEnumerable<Element> FindAllXPath(string xpath)
        {
            return innerElement.FindAllXPath(xpath);
        }

        public ElementScope FindButton(string locator)
        {
            return innerElement.FindButton(locator);
        }

        public ElementScope FindCss(string cssSelector)
        {
            return innerElement.FindCss(cssSelector);
        }

        public ElementScope FindField(string locator)
        {
            return innerElement.FindField(locator);
        }

        public ElementScope FindFieldset(string locator)
        {
            return innerElement.FindFieldset(locator);
        }

        public ElementScope FindId(string id)
        {
            return innerElement.FindId(id);
        }

        public IFrameElementScope FindIFrame(string locator)
        {
            return innerElement.FindIFrame(locator);
        }

        public ElementScope FindLink(string locator)
        {
            return innerElement.FindLink(locator);
        }

        public ElementScope FindSection(string locator)
        {
            return innerElement.FindSection(locator);
        }

        public State FindState(params State[] states)
        {
            return innerElement.FindState(states);
        }

        public ElementScope FindXPath(string xpath)
        {
            return innerElement.FindXPath(xpath);
        }

        public bool Has(ElementScope findElement)
        {
            return innerElement.Has(findElement);
        }

        public bool HasContent(string text)
        {
            return innerElement.HasContent(text);
        }

        public bool HasContentMatch(Regex pattern)
        {
            return innerElement.HasContentMatch(pattern);
        }

        public bool HasCss(string cssSelector)
        {
            return innerElement.HasCss(cssSelector);
        }

        public bool HasNo(ElementScope findElement)
        {
            return innerElement.HasNo(findElement);
        }

        public bool HasNoContent(string text)
        {
            return innerElement.HasNoContent(text);
        }

        public bool HasNoContentMatch(Regex pattern)
        {
            return innerElement.HasNoContentMatch(pattern);
        }

        public bool HasNoCss(string cssSelector)
        {
            return innerElement.HasNoCss(cssSelector);
        }

        public bool HasNoXPath(string xpath)
        {
            return innerElement.HasNoXPath(xpath);
        }

        public bool HasXPath(string xpath)
        {
            return innerElement.HasXPath(xpath);
        }

        public ElementScope Hover(Element element)
        {
            return innerElement.Hover(element);
        }

        public T Query<T>(Func<T> query, T expecting)
        {
            return innerElement.Query(query, expecting);
        }

        public TResult RetryUntilTimeout<TResult>(Func<TResult> function)
        {
            return innerElement.RetryUntilTimeout(function);
        }

        public void RetryUntilTimeout(DriverAction driverAction)
        {
            innerElement.RetryUntilTimeout(driverAction);
        }

        public void RetryUntilTimeout(Action action)
        {
            innerElement.RetryUntilTimeout(action);
        }

        public SelectFrom Select(string option)
        {
            return innerElement.Select(option);
        }

        public void TryUntil(Action tryThis, Func<bool> until, TimeSpan waitBeforeRetry)
        {
            innerElement.TryUntil(tryThis, until, waitBeforeRetry);
        }

        public void TryUntil(DriverAction tryThis, Predicate until, TimeSpan waitBeforeRetry)
        {
            innerElement.TryUntil(tryThis, until, waitBeforeRetry);
        }

        public ElementScope Uncheck(string locator)
        {
            return innerElement.Uncheck(locator);
        }

        public ElementScope WithIndividualTimeout(TimeSpan timeout)
        {
            return innerElement.WithIndividualTimeout(timeout);
        }

        public string Id
        {
            get { return innerElement.Id; }
        }

        public string Text
        {
            get { return innerElement.Text; }
        }

        public string Value
        {
            get { return innerElement.Value; }
        }

        public string Name
        {
            get { return innerElement.Name; }
        }

        public string SelectedOption
        {
            get { return innerElement.SelectedOption; }
        }

        public bool Selected
        {
            get { return innerElement.Selected; }
        }

        public object Native
        {
            get { return innerElement.Native; }
        }

        public string this[string attributeName]
        {
            get { return innerElement[attributeName]; }
        }

        public bool Exists()
        {
            return innerElement.Exists();
        }

        public bool Missing()
        {
            return innerElement.Missing();
        }
    }
}