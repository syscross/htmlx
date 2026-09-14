// Top-level constants (matches htmlx binding rule)
primary = #0070f3
bg_dark = #121212

// Blocks use clear braces {}, properties use clean space separation
body {
  bg $bg_dark
  color #fff
  font sans-serif
}

.flex-center {
  flex-center            // Macro: display: flex; justify-content: center; align-items: center;
}

#content .container {
  w 100%
  max-w 1200
  p 16 24                // padding: 16px 24px
  m 0 auto               // margin: 0 auto

  // Clean nesting with clear block boundaries
  .card {
    bg #1e1e1e
    radius 8
    border 1 solid #333

    // Pseudo-class
    :hover {
      bg #2a2a2a
      cursor pointer
    }

    // Media query blocks
    @mobile {
      p 8
      w 100%
    }
  }
}