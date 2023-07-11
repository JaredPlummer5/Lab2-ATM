using Lab2;
namespace Lab2_ATM_Test;

public class UnitTest1
{
    [Theory]
    [InlineData("12")]
    [InlineData("22")]
   
    public void ViewBalanceTest(string balance)
    {
        var deciamalBalance = Convert.ToDecimal(balance);
       Assert.Equal(deciamalBalance, Program.ViewBalanceTest(deciamalBalance));
    }

    [Theory]
    [InlineData("52", "26")]
    [InlineData("2", "34")]
    public void DepositTest(string balance, string deposit)
    {
        var decimalBalance = Convert.ToDecimal(balance);
        var decimalDeposit = Convert.ToDecimal(deposit);

        Assert.Equal(decimalBalance + decimalDeposit, Program.DepositTest(decimalBalance, decimalDeposit));
    }

    [Theory]
    [InlineData("0", "-34")]

    public void Deposit_Negitive_Input_Test(string balance, string deposit)
    {
        var decimalBalance = Convert.ToDecimal(balance);
        var decimalDeposit = Convert.ToDecimal(deposit);

        Exception ex = Assert.Throws<Exception>(() => { Program.DepositTest(decimalBalance, decimalDeposit); });


           // Program.DepositTest(decimalBalance, decimalDeposit
    }

    [Theory]
    [InlineData("75", "5")]
    [InlineData("0", "-6")]
    public void WithdrawalTest(string balance, string withdrawal)
    {
        var decimalBalance = Convert.ToDecimal(balance);
        var decimalWithdrawal = Convert.ToDecimal(withdrawal);

        Assert.Equal(decimalBalance - decimalWithdrawal, Program.WithdrawTest(decimalBalance, decimalWithdrawal));
    }
}
