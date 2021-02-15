namespace HW2Tests
{
    using System;
    using System.Collections.Generic;
    using HW2;
    using Xunit;

    /// <summary>
    /// The test class.
    /// </summary>
    public class HW2Tests
    {
        #region IsType Tests

        #region Double

        /// <summary>
        /// Test if the method returns a double.
        /// </summary>
        [Fact]
        public void ReturnDoubleCalculateGrandTotalTest()
        {
            var shippingAmount = 22D;
            var taxAmount = 5D;
            var total = 80D;
            var grandTotal = Program.CalculateGrandTotal(shippingAmount, taxAmount, total);

            Assert.IsType<double>(grandTotal);
        }

        /// <summary>
        /// Test if the method returns a double.
        /// </summary>
        [Fact]
        public void ReturnDoubleCalculateTaxTest()
        {
            var taxableItems = new List<ITaxable>
            {
                new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D },
                new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D }
            };

            var tax = Program.CalculateTax(taxableItems);

            Assert.IsType<double>(tax);
        }

        /// <summary>
        /// Test if the method returns a double.
        /// </summary>
        [Fact]
        public void ReturnDoubleCalculateShippingTest()
        {
            var shippableItems = new List<IShippable>
            {
                new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D },
                new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D }
            };

            var shipping = Program.CalculateShipping(shippableItems);

            Assert.IsType<double>(shipping);
        }

        /// <summary>
        /// Test if the method returns a double.
        /// </summary>
        [Fact]
        public void ReturnDoubleCompleteTransactionTest()
        {
            var purchasableItems = new List<IPurchasable>
            {
                new Appointment { Name = "Ethan", StartDateTime = DateTime.Now.AddHours(1), EndDateTime = DateTime.Now.AddHours(2), Price = 30D },
                new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D },
                new Snack { Price = 1D },
                new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D }
            };

            var total = Program.CompleteTransaction(purchasableItems);

            Assert.IsType<double>(total);
        }

        #endregion

        #region Class

        /// <summary>
        /// Test if the Appointment is an Appointment.
        /// </summary>
        [Fact]
        public void IsTypeAppointmentTest()
        {
            var appointment = new Appointment
            {
                Name = "Ethan",
                StartDateTime = DateTime.Now.AddHours(1),
                EndDateTime = DateTime.Now.AddHours(2),
                Price = 30D
            };

            Assert.IsType<Appointment>(appointment);
        }

        /// <summary>
        /// Test if the Book is a Book.
        /// </summary>
        [Fact]
        public void IsTypeBookTest()
        {
            var book = new Book
            {
                Title = "Welcome to the Jungle",
                Price = 20D,
                TaxRate = 0.08D,
                ShippingRate = 4D
            };

            Assert.IsType<Book>(book);
        }

        /// <summary>
        /// Test if the Snack is a Snack.
        /// </summary>
        [Fact]
        public void IsTypeSnackTest()
        {
            var snack = new Snack
            {
                Price = 1D
            };

            Assert.IsType<Snack>(snack);
        }

        /// <summary>
        /// Test if the TShirt is a TShirt.
        /// </summary>
        [Fact]
        public void IsTypeTShirtTest()
        {
            var tShirt = new TShirt
            {
                Size = "L",
                Price = 30D,
                TaxRate = 0.08D,
                ShippingRate = 4D
            };

            Assert.IsType<TShirt>(tShirt);
        }

        #endregion

        #endregion

        #region IsNotType Tests

        /// <summary>
        /// Test all other classes to make sure they are not an <see cref="Appointment"/>.
        /// </summary>
        [Fact]
        public void IsNotTypeAppointmentTest()
        {
            var book = new Book
            {
                Title = "Welcome to the Jungle",
                Price = 20D,
                TaxRate = 0.08D,
                ShippingRate = 4D
            };

            Assert.IsNotType<Appointment>(book);

            var tShirt = new TShirt
            {
                Price = 20D,
                TaxRate = 0.08D,
                ShippingRate = 4D
            };

            Assert.IsNotType<Appointment>(tShirt);

            var snack = new Snack
            {
                Price = 30D
            };

            Assert.IsNotType<Appointment>(snack);
        }

        /// <summary>
        /// Test all other classes to make sure they are not a <see cref="Book"/>.
        /// </summary>
        [Fact]
        public void IsNotTypeBookTest()
        {
            var appointment = new Appointment
            {
                Name = "Ethan",
                StartDateTime = DateTime.Now.AddHours(1),
                EndDateTime = DateTime.Now.AddHours(2),
                Price = 30D
            };

            Assert.IsNotType<Book>(appointment);

            var snack = new Snack
            {
                Price = 1D,
            };

            Assert.IsNotType<Book>(snack);

            var tShirt = new TShirt
            {
                Price = 20D,
                TaxRate = 0.08D,
                ShippingRate = 4D
            };

            Assert.IsNotType<Book>(tShirt);
        }

        /// <summary>
        /// Test all other classes to make sure they are not a <see cref="Snack"/>.
        /// </summary>
        [Fact]
        public void IsNotTypeSnackTest()
        {
            var appointment = new Appointment
            {
                Name = "Ethan",
                StartDateTime = DateTime.Now.AddHours(1),
                EndDateTime = DateTime.Now.AddHours(2),
                Price = 30D
            };

            Assert.IsNotType<Snack>(appointment);

            var book = new Book
            {
                Title = "Welcome to the Jungle",
                Price = 20D,
                TaxRate = 0.08D,
                ShippingRate = 4D
            };

            Assert.IsNotType<Snack>(book);

            var tShirt = new TShirt
            {
                Price = 20D,
                TaxRate = 0.08D,
                ShippingRate = 4D
            };

            Assert.IsNotType<Snack>(tShirt);
        }

        /// <summary>
        /// Test all other classes to make sure they are not a <see cref="TShirt"/>.
        /// </summary>
        [Fact]
        public void IsNotTypeTShirtTest()
        {
            var appointment = new Appointment
            {
                Name = "Ethan",
                StartDateTime = DateTime.Now.AddHours(1),
                EndDateTime = DateTime.Now.AddHours(2),
                Price = 30D
            };

            Assert.IsNotType<TShirt>(appointment);

            var book = new Book
            {
                Title = "Welcome to the Jungle",
                Price = 20D,
                TaxRate = 0.08D,
                ShippingRate = 4D
            };

            Assert.IsNotType<TShirt>(book);

            var snack = new Snack
            {
                Price = 1D,
            };

            Assert.IsNotType<TShirt>(snack);
        }

        #endregion

        #region IsNotNull Tests

        /// <summary>
        /// Make sure the <see cref="Appointment"/> is not null on instantiation.
        /// </summary>
        [Fact]
        public void IsNotNullAppointmentTest()
        {
            var appointment = new Appointment();
            Assert.NotNull(appointment);
        }

        /// <summary>
        /// Make sure the <see cref="Book"/> is not null on instantiation.
        /// </summary>
        [Fact]
        public void IsNotNullBookTest()
        {
            var book = new Book();
            Assert.NotNull(book);
        }

        /// <summary>
        /// Make sure the <see cref="Snack"/> is not null on instantiation.
        /// </summary>
        [Fact]
        public void IsNotNullSnackTest()
        {
            var snack = new Snack();
            Assert.NotNull(snack);
        }

        /// <summary>
        /// Make sure the <see cref="TShirt"/> is not null on instantiation.
        /// </summary>
        [Fact]
        public void IsNotNullTShirtTest()
        {
            var tShirt = new TShirt();
            Assert.NotNull(tShirt);
        }

        #endregion

        #region IsAssignableFrom Tests

        #region Appointment

        /// <summary>
        /// Make sure an Appointment inherits that of an <see cref="IPurchasable"/>
        /// </summary>
        [Fact]
        public void IsAssignableFromIPurchasableAppointmentTest()
        {
            var appointment = new Appointment();
            Assert.IsAssignableFrom<IPurchasable>(appointment);
        }

        #endregion

        #region Book

        /// <summary>
        /// Make sure a Book inherits that of an <see cref="IPurchasable"/>
        /// </summary>
        [Fact]
        public void IsAssignableFromIPurchasableBookTest()
        {
            var book = new Book();
            Assert.IsAssignableFrom<IPurchasable>(book);
        }

        /// <summary>
        /// Make sure a Book inherits that of an <see cref="IShippable"/>
        /// </summary>
        [Fact]
        public void IsAssignableFromIShippableBookTest()
        {
            var book = new Book();
            Assert.IsAssignableFrom<IShippable>(book);
        }

        /// <summary>
        /// Make sure a Book inherits that of an <see cref="ITaxable"/>
        /// </summary>
        [Fact]
        public void IsAssignableFromITaxableBookTest()
        {
            var book = new Book();
            Assert.IsAssignableFrom<ITaxable>(book);
        }

        #endregion

        #region Snack

        /// <summary>
        /// Make sure a Snack inherits that of an <see cref="IPurchasable"/>
        /// </summary>
        [Fact]
        public void IsAssignableFromIPurchasableSnackTest()
        {
            var snack = new Snack();
            Assert.IsAssignableFrom<IPurchasable>(snack);
        }

        #endregion

        #region TShirt

        /// <summary>
        /// Make sure a TShirt inherits that of an <see cref="IPurchasable"/>
        /// </summary>
        [Fact]
        public void IsAssignableFromIPurchasableTShirtTest()
        {
            var tShirt = new TShirt();
            Assert.IsAssignableFrom<IPurchasable>(tShirt);
        }

        /// <summary>
        /// Make sure a TShirt inherits that of an <see cref="IShippable"/>
        /// </summary>
        [Fact]
        public void IsAssignableFromIShippableTShirtTest()
        {
            var tShirt = new TShirt();
            Assert.IsAssignableFrom<IShippable>(tShirt);
        }

        /// <summary>
        /// Make sure a TShirt inherits that of an <see cref="ITaxable"/>
        /// </summary>
        [Fact]
        public void IsAssignableFromITaxableTShirtTest()
        {
            var tShirt = new TShirt();
            Assert.IsAssignableFrom<ITaxable>(tShirt);
        }

        #endregion

        #endregion

        #region Calculatations Tests

        #region Tax

        #region Equal

        /// <summary>
        /// Test the Tax() method of a <see cref="Book"/> to see if it returns an expected value from defined parameters.
        /// </summary>
        [Fact]
        public void CalculateBookTaxEqualTest()
        {
            var book = new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D };

            var tax = book.Tax();

            Assert.Equal(1.60, tax);
        }

        /// <summary>
        /// Test the Tax() method of a <see cref="TShirt"/> to see if it returns an expected value from defined parameters.
        /// </summary>
        [Fact]
        public void CalculateTShirtTaxEqualTest()
        {
            var tShirt = new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D };

            var tax = tShirt.Tax();

            Assert.Equal(2.40, tax);
        }

        /// <summary>
        /// Test the Ship() method of a <see cref="Book"/> to see if it returns the ShippingRate.
        /// </summary>
        [Fact]
        public void CalculateBookShipEqualTest()
        {
            var book = new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D };

            var shippingRate = book.Ship();

            Assert.Equal(book.ShippingRate, shippingRate);
        }

        /// <summary>
        /// Test the Ship() method of a <see cref="TShirt"/> to see if it returns the ShippingRate.
        /// </summary>
        [Fact]
        public void CalculateTShirtShipEqualTest()
        {
            var tShirt = new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D };

            var shippingRate = tShirt.Ship();

            Assert.Equal(tShirt.ShippingRate, shippingRate);
        }

        #endregion

        #region GreaterThanZero

        /// <summary>
        /// Test the Tax() method of a <see cref="Book"/> to see if it returns a number greater than zero.
        /// </summary>
        [Fact]
        public void CalculateBookTaxGreaterThanZeroTest()
        {
            var book = new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D };

            var tax = book.Tax();

            Assert.True(tax > 0);
        }

        /// <summary>
        /// Test the Tax() method of a <see cref="TShirt"/> to see if it returns a number greater than zero.
        /// </summary>
        [Fact]
        public void CalculateTShirtTaxGreaterThanZeroTest()
        {
            var tShirt = new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D };

            var tax = tShirt.Tax();

            Assert.True(tax > 0);
        }

        #endregion

        #endregion

        #region Equal

        /// <summary>
        /// Test the CompleteTransaction() method to see if it returns an expected value from defined parameters.
        /// </summary>
        [Fact]
        public void CalculateCompleteTransactionEqualTest()
        {
            var purchasableItems = new List<IPurchasable>
            {
                new Appointment { Name = "Ethan", StartDateTime = DateTime.Now.AddHours(1), EndDateTime = DateTime.Now.AddHours(2), Price = 30D },
                new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D },
                new Snack { Price = 2.50 },
                new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D }
            };

            var transaction = Program.CompleteTransaction(purchasableItems);

            Assert.Equal(82.50, transaction);
        }

        /// <summary>
        /// Test the CalculateShipping() method to see if it returns an expected value from defined parameters.
        /// </summary>
        [Fact]
        public void CalculateShippingEqualTest()
        {
            var shippableItems = new List<IShippable>
            {
                new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D },
                new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D }
            };

            var shipping = Program.CalculateShipping(shippableItems);

            Assert.Equal(8.00, shipping);
        }

        /// <summary>
        /// Test the CalculateTax() method to see if it returns an expected value from defined parameters.
        /// </summary>
        [Fact]
        public void CalculateTaxEqualTest()
        {
            var taxableItems = new List<ITaxable>
            {
                new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D },
                new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D }
            };

            var tax = Program.CalculateTax(taxableItems);

            Assert.Equal(4.00, tax);
        }

        /// <summary>
        /// Test the CalculateGrandTotal() method to see if it returns an expected value from defined parameters.
        /// </summary>
        [Fact]
        public void CalculateGrandTotalEqualTest()
        {
            var shippingAmount = 9.99;
            var taxAmount = 2.18;
            var total = 118;

            var grandTotal = Program.CalculateGrandTotal(shippingAmount, taxAmount, total);

            Assert.Equal(130.17, grandTotal);
        }

        #endregion

        #region GreaterThanZero

        /// <summary>
        /// Test the CompleteTransaction() method to see if it returns a number greater than zero.
        /// </summary>
        [Fact]
        public void CalculateCompleteTransactionGreaterThanZeroTest()
        {
            var purchasableItems = new List<IPurchasable>
            {
                new Appointment { Name = "Ethan", StartDateTime = DateTime.Now.AddHours(1), EndDateTime = DateTime.Now.AddHours(2), Price = 30D },
                new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D },
                new Snack { Price = 2.50 },
                new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D }
            };

            var transaction = Program.CompleteTransaction(purchasableItems);

            Assert.True(transaction > 0);
        }

        /// <summary>
        /// Test the CalculateShipping() method to see if it returns a number greater than zero.
        /// </summary>
        [Fact]
        public void CalculateShippingGreaterThanZeroTest()
        {
            var shippableItems = new List<IShippable>
            {
                new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D },
                new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D }
            };

            var shipping = Program.CalculateShipping(shippableItems);

            Assert.True(shipping > 0);
        }

        /// <summary>
        /// Test the CalculateTax() method to see if it returns a number greater than zero.
        /// </summary>
        [Fact]
        public void CalculateTaxGreaterThanZeroTest()
        {
            var taxableItems = new List<ITaxable>
            {
                new Book { Title = "Welcome to the Jungle", Price = 20D, TaxRate = 0.08D, ShippingRate = 4D },
                new TShirt { Size = "L", Price = 30D, TaxRate = 0.08D, ShippingRate = 4D }
            };

            var tax = Program.CalculateTax(taxableItems);

            Assert.True(tax > 0);
        }

        /// <summary>
        /// Test the CalculateGrandTotal() method to see if it returns a number greater than zero.
        /// </summary>
        [Fact]
        public void CalculateGrandTotalGreaterThanZeroTest()
        {
            var shippingAmount = 9.99;
            var taxAmount = 2.18;
            var total = 118;

            var grandTotal = Program.CalculateGrandTotal(shippingAmount, taxAmount, total);

            Assert.True(grandTotal > 0);
        }

        #endregion

        #endregion
    }
}
