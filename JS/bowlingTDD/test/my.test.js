getScore = function(throws){
  return 0
}

describe("My tests", function () {
  it("test_zero", function () {
    expect(0).toBe(getScore('00 00 00 00 00 00 00 00 00 00'))
  })

  it.skip("test_non_zero", function () {
    expect(12).toBe(getScore('02 00 00 00 00 30 00 00 00 07'))
  })

  it.skip("test_strike_no_extra", function () {
    expect(20).toBe(getScore('2/ 00 00 00 00 30 00 00 00 07'))
  })

  it.skip("test_two_strikes_no_extra", function () {
    expect(27).toBe(getScore('2/ 00 00 00 00 3/ 00 00 00 07'))
  })

  it.skip("test_spare_with_extra", function () {
    expect(35).toBe(getScore('2/ 00 00 00 00 3/ 40 00 00 07'))
  })

  it.skip("test_strike_with_no_extra", function () {
    expect(26).toBe(getScore('20 00 X 00 00 30 40 00 00 07'))
  })

  it.skip("test_strike_with_one_extra", function () {
    expect(28).toBe(getScore('20 00 X 10 00 30 40 00 00 07'))
  })

  it.skip("test_strike_with_two_extras", function () {
    expect(32).toBe(getScore('20 00 X 12 00 30 40 00 00 07'))
  })

  it.skip("test_two_strikes_with_two_extras", function () {
    expect(53).toBe(getScore('20 X X 12 00 30 40 00 00 07'))
  })

  it.skip("test_strike_with_spare_as_extra", function () {
    expect(46).toBe(getScore('20 00 X 1/ 03 04 00 00 00 70'))
  })

  it.skip("test_strike_with_spare_as_extra_and_spar_with_strike", function () {
    expect(67).toBe(getScore('20 00 X 1/ X 04 00 00 00 70'))
  })

  it.skip("test_last_round_spare_extra", function () {
    expect(50).toBe(getScore('20 00 X 1/ 03 04 00 00 00 0/ 1'))
  })

  it.skip("test_last_round_strike_extra", function () {
    expect(145).toBe(getScore('12 4/ 20 X 35 X X 9/ 4/ X 81'))
  })

  it.skip("target_test", function () {
    expect(146).toBe(getScore('12 4/ 20 X 35 X X 9/ 4/ X 9/'))
  })
})
