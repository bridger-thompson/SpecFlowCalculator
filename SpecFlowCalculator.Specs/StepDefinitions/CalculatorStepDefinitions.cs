using FluentAssertions;

namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {

        private readonly Calculator _calculator = new Calculator();

        private int _result;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            _result = _calculator.Subtract();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _result = _calculator.Multiply();
        }

        [When(@"operation \+ is done to the number (.*)")]
        public void WhenOperationIsDoneToTheNumber(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.Add();
        }

        [When(@"operation \/ is done to the number (.*)")]
        public void WhenDivideIsDoneToTheNumber(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.Divide();
        }

        [When(@"operation \- is done to the number (.*)")]
        public void WhenSubtractIsDoneToTheNumber(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.Subtract();
        }

        [When(@"operation \% is done to the number (.*)")]
        public void WhenModuloIsDoneToTheNumber(int p0)
        {
            _calculator.SecondNumber = p0;
            _result = _calculator.Modulo();
        }
    }
}