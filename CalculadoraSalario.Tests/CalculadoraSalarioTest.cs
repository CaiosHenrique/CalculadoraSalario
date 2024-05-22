namespace CalculadoraSalario.Tests;

public class CalculadoraSalarioTest
{
    [Fact]
    public void Should_pay_5_Precent_INSS_Tax()
    {
        CalculadoraSalario calculadora = new CalculadoraSalario();
        double salarioliquido = 600;

        double inss = calculadora.GetDescontoInss(salarioliquido);
        double desconto = 30.0;

        Assert.Equal(desconto, inss);
      
    }

    [Fact]
    public void Should_pay_10_Precent_INSS_Tax()
    {
        CalculadoraSalario calculadora = new CalculadoraSalario();
        double salarioliquido = 1200;

        double inss = calculadora.GetDescontoInss(salarioliquido);
        double desconto = 120.0;

        Assert.Equal(desconto, inss);
    }

    [Fact]
    public void Should_Throw_Exception_When_Salary_Is_Negative()
    {
        CalculadoraSalario calculadora = new CalculadoraSalario();
        double salarioliquido = -1200;

        Assert.Throws<ArgumentException>(() => calculadora.GetDescontoInss(salarioliquido));


    }

    [Fact]
    public void Should_pay_Ir_Low_1000()
    {
        CalculadoraSalario calculadora = new CalculadoraSalario();
        double bruto = 600;

        double ir = calculadora.getDescontoIr(bruto);
        double desconto = 0.0;

        Assert.Equal(desconto, ir);
    }

    [Fact]
    public void Should_pay_Ir_Between_1000_And_3000()
    {
        CalculadoraSalario calculadora = new CalculadoraSalario();
        double bruto = 2000;

        double ir = calculadora.getDescontoIr(bruto);
        double desconto = 200.0;

        Assert.Equal(desconto, ir);
    }

    [Fact]
    public void Should_pay_Ir_Above_3000()
    {
        CalculadoraSalario calculadora = new CalculadoraSalario();
        double bruto = 4000;

        double ir = calculadora.getDescontoIr(bruto);
        double desconto = 800.0;

        Assert.Equal(desconto, ir);
    }
}