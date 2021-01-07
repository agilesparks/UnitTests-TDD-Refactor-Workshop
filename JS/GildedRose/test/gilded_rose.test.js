const {Shop, Item} = require("../src/gilded_rose");
var approvals = require('approvals');
approvals.configure({
     reporters: ['beyondcompare']
       });

describe("Gilded Rose", function() {
  it("should foo", function() {
    const gildedRose = new Shop([new Item("foo", 0, 0)]);
    const items = gildedRose.updateQuality();
    expect(items[0].name).toBe("fixme");
  });

  it('should be able to use Approvals', function () {
    var data = "Hello World 2 !";
    approvals.verify('.','example_test',data);  // or this.verifyAsJSON(data)
  });
});
