using NewTalents.Models;

namespace NewTalents;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "02/02/2020";
        Calculadora calculadora = new Calculadora("02/02/2020");
        return calculadora;
    }

    [Theory]
    [InlineData (1, 2, 3)]
    [InlineData(7, 9, 16)]
    public void TestSomar(int val1, int val2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.somar(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (16, 4, 12)]
    [InlineData(17, 6, 11)]
    public void TestSubtrair(int val1, int val2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.subtrair(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (2, 4, 8)]
    [InlineData(3, 6, 18)]
    public void TestMultiplicar(int val1, int val2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.multiplicar(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (6, 3, 2)]
    [InlineData(12, 4, 3)]
    public void TestDividir(int val1, int val2, int resultado)
    {
        Calculadora calculadora = construirClasse();

        int resultadoCalculadora = calculadora.dividir(val1, val2);
        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestDividirPorZero()
    {
        Calculadora calculadora = construirClasse();
        Assert.Throws<DivideByZeroException>(() => calculadora.dividir(3, 0));
    }

    [Fact]
    public void TestHistorico()
    {
        Calculadora calculadora = construirClasse();
        calculadora.somar(5 ,4);
        calculadora.dividir(8, 2);
        calculadora.multiplicar(2, 3);
        calculadora.subtrair(5, 2);
        calculadora.somar(5, 2);

        var lista = calculadora.historico();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count);
    }


}