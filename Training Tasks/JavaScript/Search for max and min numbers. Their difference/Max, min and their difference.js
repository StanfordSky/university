function differenceInAges(ages){
  var result = [Math.min.apply(Math, ages), Math.max.apply(Math, ages), Math.max.apply(Math, ages)-Math.min.apply(Math, ages)];
  return result;
}
