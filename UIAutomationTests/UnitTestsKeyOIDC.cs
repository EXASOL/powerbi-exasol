﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Xunit;

namespace UIAutomationTests
{
    [Collection("NotParallel")]
    public class UnitTestsKeyOIDC : IClassFixture<TestFixture>
    {
        TestFixture testFixture;
        public UnitTestsKeyOIDC(TestFixture tf)
        {
            testFixture = tf;
            tf.Authenticate(TestFixture.AuthenticationMethod.KeyOIDCToken);
        }
        //2 tests here will be sufficient for now since we just want to see if we can authenticate and fetch data with odbc.datasource and odbc.query
        [Fact]
        public void TestSqlQueryLimit5()
        {
            string MQueryExpression = File.ReadAllText("QueryPqFiles/CustomQuery.query.pq");

            var (error, grid) = testFixture.Test(MQueryExpression);

            Assert.True(String.IsNullOrWhiteSpace(error), $@"Errormessage: {error}");
            Assert.True(grid.RowCount == 5 + 1, $@"actual rowCount is {grid.RowCount}");
        }
        [Fact]
        public void TestAW()
        {
            string MQueryExpression = File.ReadAllText("QueryPqFiles/ExasolAW.query.pq");

            var (error, grid) = testFixture.Test(MQueryExpression);


            Assert.True(String.IsNullOrWhiteSpace(error), $@"Errormessage: {error}");
            Assert.True(grid.RowCount > 1, $@"actual rowCount is {grid.RowCount}");
        }
    }
}
