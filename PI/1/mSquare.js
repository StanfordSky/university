
function generateMagicSquare(n)  {
    let last = n * n;
    let a = [];
  
    for (let m = 0; m < n; m++) a[m] = [];
  
    let i = 0;
    let j = Math.floor(n / 2);
  
    for (let c = 1; c <= last; c++) {
      if (i < 0) i = n - -i;
      if (i >= n) i = i - n;
      if (j < 0) j = n - -j;
      if (j >= n) j = j - n;
  
      a[i][j] = c;
  
      if (c % n === 0) {
        i++;
      } else {
        i--;
        j++;
      }
    }
    return a;
};
  
function isMagicSquare(mat) {
    let N = mat.length;
  
    let sumd1 = 0,
      sumd2 = 0;
    for (let i = 0; i < N; i++) {
  
      sumd1 = sumd1 + mat[i][i];
      sumd2 = sumd2 + mat[i][N - 1 - i];
    }
  
    if (sumd1 !== sumd2) return false;
  
    for (let i = 0; i < N; i++) {
      let colSum = 0;
      let rowSum = 0;
      for (let j = 0; j < N; j++) {
        rowSum += mat[i][j];
        colSum += mat[j][i];
      }
      if (rowSum !== colSum || colSum !== sumd1) return false;
    }
    return true;
}


exports.generateMagicSquare = generateMagicSquare;
exports.isMagicSquare = isMagicSquare;
