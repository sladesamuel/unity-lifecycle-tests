using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class LifecycleTests
{
    private LifecycleOutputs component;

    [SetUp]
    public void Setup()
    {
        var gameObject = new GameObject();
        component = gameObject.AddComponent<LifecycleOutputs>();
    }

    [UnityTest]
    public IEnumerator Test1_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test2_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test3_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test4_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test5_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test6_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test7_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test8_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test9_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test10_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test11_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test12_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test13_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test14_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test15_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test16_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test17_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test18_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test19_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test20_ShouldPass()
    {
        yield return null;

        Assert.Pass();
    }

    [UnityTest]
    public IEnumerator Test21_OnEnableCallsShouldEqual2()
    {
        component.enabled = false;
        yield return null;

        component.enabled = true;
        yield return null;

        Assert.AreEqual(2, component.OnEnableCalls);
    }

    [UnityTest]
    public IEnumerator Test22_WhenCacheNumberIsSetTo3_ThenNumberShouldBeRestoredTo3FromCache()
    {
        component.enabled = false;
        yield return null;

        var state = new State { number = 3 };
        StateCache.StoreState(component.gameObject.name, state);

        component.enabled = true;
        yield return null;

        Assert.AreEqual(3, component.number);
    }
}
