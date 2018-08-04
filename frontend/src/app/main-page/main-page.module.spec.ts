import { MainPageModule } from './main-page.module';

describe('MainPageModule', () => {
  let mainPageModule: MainPageModule;

  beforeEach(() => {
    mainPageModule = new MainPageModule();
  });

  it('should create an instance', () => {
    expect(mainPageModule).toBeTruthy();
  });
});
