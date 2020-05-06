﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegexParser.Nodes;
using RegexParser.Nodes.CharacterClass;
using Shouldly;

namespace RegexParser.UnitTest.Nodes.CharacterClass
{
    [TestClass]
    public class CharacterClassRangeNodeTest
    {
        [TestMethod]
        public void ToStringOnCharacterClassRangeNodeShouldReturnRangeWithStartAndEndSeperatedByDash()
        {
            // Arrange
            var target = new CharacterClassRangeNode(new CharacterNode('a'), new CharacterNode('z'));

            // Act
            var result = target.ToString();

            // Assert
            result.ShouldBe("a-z");
        }
    }
}
