import { SomePipe } from './some.pipe';

describe('SomePipe', () => {
  it('create an instance', () => {
    const pipe = new SomePipe();
    expect(pipe).toBeTruthy();
  });
});
